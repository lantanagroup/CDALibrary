using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDALibrary.Core.Logic
{
    public class ClinicalDocumentDesigner : IDisposable
    {
        private static Dictionary<Guid, int> threadsDesigning = new Dictionary<Guid, int>();
        private Guid currentId = Guid.NewGuid();

        public ClinicalDocumentDesigner()
        {
            lock (threadsDesigning)
            {
                threadsDesigning.Add(currentId, Thread.CurrentThread.ManagedThreadId);
            }
        }

        public static bool IsDesigning
        {
            get
            {
                return threadsDesigning.ContainsValue(Thread.CurrentThread.ManagedThreadId);
            }
        }

        public void Dispose()
        {
            lock (threadsDesigning)
            {
                threadsDesigning.Remove(currentId);
            }
        }
    }
}
