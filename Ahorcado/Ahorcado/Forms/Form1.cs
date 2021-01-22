using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        Operaciones ejemplo1;
        public Form1()
        {
            InitializeComponent();
            ejemplo1 = new Operaciones();
            ejemplo1.Reiniciar();
            ejemplo1.Resolver();
        }

    }
}
