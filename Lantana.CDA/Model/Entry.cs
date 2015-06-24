using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CDALibrary.Core.Model
{
    public partial class Entry
    {
        public Entry(IClinicalStatement clinicalStatement)
        {
            this.itemField = clinicalStatement;
        }

        [XmlIgnore]
        public Act ItemAct
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new Act();

                return this.itemField as Act;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public Encounter ItemEncounter
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new Encounter();

                return this.itemField as Encounter;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public Observation ItemObservation
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new Observation();

                return this.itemField as Observation;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public ObservationMedia ItemObservationMedia
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new ObservationMedia();

                return this.itemField as ObservationMedia;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public Organizer ItemOrganizer
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new Organizer();

                return this.itemField as Organizer;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public Procedure ItemProcedure
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new Procedure();

                return this.itemField as Procedure;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public RegionOfInterest ItemRegionOfInterest
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new RegionOfInterest();

                return this.itemField as RegionOfInterest;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public SubstanceAdministration ItemSubstanceAdministration
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new SubstanceAdministration();

                return this.itemField as SubstanceAdministration;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlIgnore]
        public Supply ItemSupply
        {
            get
            {
                if (this.itemField == null)
                    this.itemField = new Supply();

                return this.itemField as Supply;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
