using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lantana.CDA.Model;
using Lantana.CDA.Logic;

namespace Lantana.CDA.Tests
{
    
    
    /// <summary>
    ///This is a test class for ClincalDocumentFactoryTest and is intended
    ///to contain all ClincalDocumentFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ClincalDocumentFactoryTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CreateDocument
        ///</summary>
        [TestMethod()]
        public void CreateDocumentTest()
        {
            string title = "Test Document Title";
            string id = Guid.NewGuid().ToString();

            Author author = new Author(new II("20cf14fb-b65c-4c8c-a54d-b0cca834c18c"), DateTime.Now);
            RecordTarget recordTarget = new RecordTarget(new II("2.16.840.1.113883.19.5", "996-756-495"));
            Custodian custodian = new Custodian(new II("2.16.840.1.113883.19.5"), "Good Health Clinic");

            ClinicalDocument cda = null;

            using (new ClinicalDocumentDesigner())
            {
                cda = ClinicalDocumentFactory.CreateDocument(
                    id,
                    title,
                    new CE("34133-9", "2.16.840.1.113883.6.1", null, "Summarization of episode note"),
                    ConfidentialityCodes.Normal,
                    author,
                    custodian,
                    recordTarget);

                Act newAct = new Act(ActClassCodes.ACT, ActMoodCodes.EVN, new CE("1234", "2.16.840.1.113883.6.1"));
                Encounter newEncounter = new Encounter(EncounterMoodCodes.EVN);
                Observation newObservation = new Observation(ActClassObservationClassCodes.OBS, ObservationMoodCodes.EVN, new CD("1234", "2.16.840.1.113883.6.1"));
                ObservationMedia newObservationMedia = new ObservationMedia(new ED());
                Organizer newOrganizer = new Organizer(OrganizerClassCodes.BATTERY, new CS());
                Procedure newProcedure = new Procedure(ProcedureMoodCodes.EVN);
                RegionOfInterest newRegionOfInterest = new RegionOfInterest(new II(), RegionOfInterestCodes.CIRCLE, new RegionOfInterestvalue());
                SubstanceAdministration newSubstanceAdmin = new SubstanceAdministration(SubstanceMoodCodes.EVN,
                            new Consumable(
                                new ManufacturedProduct(
                                    new Material())));
                Supply newSupply = new Supply(SupplyClassCodes.SPLY, SubstanceMoodCodes.EVN);

                Section firstSection = new Section(
                    new CE("2342", "2.16.840.1.113883.6.1"), 
                    new ST("Test section's title"));

                firstSection.AddEntries(
                    newAct,
                    newEncounter,
                    newObservation,
                    newObservationMedia,
                    newOrganizer,
                    newProcedure,
                    newRegionOfInterest,
                    newSubstanceAdmin,
                    newSupply);

                StructuredBody body = cda.AddStructuredBody(firstSection);
            }

            Assert.IsNotNull(cda.Title);
            Assert.IsNotNull(cda.Title.Text);
            Assert.AreEqual(1, cda.Title.Text.Length);
            Assert.AreEqual(title, cda.Title.Text[0]);
            Assert.AreEqual(ClinicalDocumentFactory.TypeIdRoot, cda.TypeId.Root);
            Assert.AreEqual(ClinicalDocumentFactory.TypeIdExtension, cda.TypeId.Extension);

            string xml = cda.GetXml();
            bool valid = Helper.ValidateCDA(xml);

            Assert.AreEqual(true, valid, "Expected CDA document to validate against the CDA schema");
        }

        /// <summary>
        ///A test for GetDate
        ///</summary>
        [TestMethod()]
        public void GetDateTest()
        {
            DateTime date = DateTime.Now;
            string expected = date.ToString("yyyyMMddhhmmss");
            string actual = ClinicalDocumentFactory.GetDate(date);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetDateNow
        ///</summary>
        [TestMethod()]
        public void GetDateNowTest()
        {
            string actual = ClinicalDocumentFactory.GetDateNow();

            Assert.IsNotNull(actual);
            Assert.AreNotEqual(string.Empty, actual);

            DateTime date = DateTime.ParseExact(actual, ClinicalDocumentFactory.DefaultDateFormat, System.Globalization.CultureInfo.InvariantCulture);

            Assert.AreNotEqual(DateTime.MinValue, date);
        }

        /// <summary>
        ///A test for GetDate
        ///</summary>
        [TestMethod()]
        public void ParseDateTest()
        {
            string date = "20110802092621";     // y = 2011, m = 08, d = 02, h = 09, m = 26, s = 21
            DateTime actual = ClinicalDocumentFactory.GetDate(date);

            Assert.AreEqual(2011, actual.Year);
            Assert.AreEqual(8, actual.Month);
            Assert.AreEqual(2, actual.Day);
            Assert.AreEqual(9, actual.Hour);
            Assert.AreEqual(26, actual.Minute);
            Assert.AreEqual(21, actual.Second);

            date = "20100904";     // y = 2010, m = 09, d = 04
            actual = ClinicalDocumentFactory.GetDate(date);

            Assert.AreEqual(2010, actual.Year);
            Assert.AreEqual(9, actual.Month);
            Assert.AreEqual(4, actual.Day);

            date = "2009";     // y = 2009
            actual = ClinicalDocumentFactory.GetDate(date);

            Assert.AreEqual(2009, actual.Year);
        }
    }
}
