using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueOndas_APP.Models.Configuration
{
    public class AppState
    {
        public bool hideNavBars { get; private set; }

        public event Action OnChange;

        public void hide(bool state)
        {
            hideNavBars = state;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
