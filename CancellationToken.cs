using System.Threading;

namespace ParallelCore {
    public class CancellationToken {
        volatile bool isCancelled = false;

        public bool IsCancelled => isCancelled;
        
        public void Cancel() {
            isCancelled = true;
        }
    }
}