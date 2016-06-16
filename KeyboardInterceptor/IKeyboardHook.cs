using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardInterceptor
{
    public interface IKeyboardHook : IDisposable
    {
        /// <summary>
        /// Registers a hot key in the system.
        /// </summary>
        /// <param name="modifier">The modifiers that are associated with the hot key.</param>
        /// <param name="key">The key itself that is associated with the hot key.</param>
        void RegisterHotKey(ModifierKeys modifier, Keys key);

        /// <summary>
        /// A hot key has been pressed.
        /// </summary>
        event EventHandler<KeyPressedEventArgs> KeyPressed;

        new void Dispose();
    }

}
