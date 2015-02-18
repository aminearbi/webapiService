using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourcingWebAPI.Data.Infrastructure
    {
    public class Disposable:IDisposable
        {
        private bool isDisposed;
        // Use C# destructor syntax for finalization code.
        // This destructor will run only if the Dispose method
        // does not get called.
        // It gives your base class the opportunity to finalize.
        // Do not provide destructors in types derived from this class.

        ~Disposable ()
            {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(false) is optimal in terms of
            // readability and maintainability.

            Dispose (false);
            }

        public void Dispose ()
            {
            Dispose (true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize (this);
            }
        private void Dispose ( bool disposing )
            {
            // Check to see if Dispose has already been called.
            if (!isDisposed && disposing)
                {
                DisposeCore ();
                }
            isDisposed = true;
            }

        protected virtual void DisposeCore ()
            {
            }

        }
    }
