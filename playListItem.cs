using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBAudioPlayer
{
    class playListItem : Label
    {
        public delegate void eventHandler(object sender, EventArgs e);
        public string filePath;

        public playListItem(string _filePath, eventHandler clickety)
        {
            filePath = _filePath;
            this.Text = filePath;
            this.Size = new System.Drawing.Size(194, 16);
            this.AutoSize = false;
            this.Click += new EventHandler(clickety);
        }
    }
}
