using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WowMaskTranslator
{
    public partial class Form1 : Form
    {
        string tipoSeleccionado;
        int numero;

        enum mechanic_immune_mask
        {
            MECHANIC_CHARM          = 1,
            MECHANIC_DISORIENTED    = 2,
            MECHANIC_DISARM         = 4,
            MECHANIC_DISTRACT       = 8,
            MECHANIC_FEAR           = 16,
            MECHANIC_GRIP           = 32,
            MECHANIC_ROOT           = 64,
            MECHANIC_PACIFY         = 128,
            MECHANIC_SILENCE        = 252,
            MECHANIC_SLEEP          = 512,
            MECHANIC_SNARE          = 1024,
            MECHANIC_STUN           = 2048,
            MECHANIC_FREEZE         = 4096,
            MECHANIC_KNOCKOUT       = 8192,
            MECHANIC_BLEED          = 16384,
            MECHANIC_BANDAGE        = 32768,
            MECHANIC_POLYMORPH      = 65536,
            MECHANIC_BANISH         = 131072,
            MECHANIC_SHIELD         = 262144,
            MECHANIC_SHACKLE        = 524288,
            MECHANIC_MOUNT          = 1048576,
            MECHANIC_INFECTED       = 2097152,
            MECHANIC_TURN           = 4194304,
            MECHANIC_HORROR         = 8388608,
            MECHANIC_INVULNERABILITY= 16777216,
            MECHANIC_INTERRUPT      = 33554432,
            MECHANIC_DAZE           = 67108864,
            MECHANIC_DISCOVERY      = 134217728,
            MECHANIC_IMMUNE_SHIELD  = 268435456,
            MECHANIC_SAPPED         = 536870912,
            MECHANIC_ENRAGED        = 1073741824
        }

        public Form1() {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e) {
            numero = Int32.TryParse(tbNumero.Text, out numero) ? numero : 0;

            string texto = "";
            List<string> tipos = new List<string>();

            switch(tipoSeleccionado) {
                case "mechanic_immune_mask":

                    if (numero > 2147483647 || numero == 0) {
                        // Numero incorrecto, 31 valores
                        texto = "El número introducido es incorrecto";
                        textBox1.Text = texto;
                        break;
                    }

                    if (numero >= (int)mechanic_immune_mask.MECHANIC_ENRAGED) {
                        tipos.Add("MECHANIC_ENRAGED");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_ENRAGED;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_SAPPED) {
                        tipos.Add("MECHANIC_SAPPED");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_SAPPED;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_IMMUNE_SHIELD) {
                        tipos.Add("MECHANIC_IMMUNE_SHIELD");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_IMMUNE_SHIELD;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_DISCOVERY) {
                        tipos.Add("MECHANIC_DISCOVERY");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_DISCOVERY;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_INTERRUPT) {
                        tipos.Add("MECHANIC_INTERRUPT");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_INTERRUPT;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_INVULNERABILITY) {
                        tipos.Add("MECHANIC_INVULNERABILITY");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_INVULNERABILITY;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_HORROR) {
                        tipos.Add("MECHANIC_HORROR");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_HORROR;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_TURN) {
                        tipos.Add("MECHANIC_TURN");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_TURN;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_INFECTED) {
                        tipos.Add("MECHANIC_INFECTED");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_INFECTED;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_MOUNT) {
                        tipos.Add("MECHANIC_MOUNT");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_MOUNT;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_SHACKLE) {
                        tipos.Add("MECHANIC_SHACKLE");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_SHACKLE;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_SHIELD) {
                        tipos.Add("MECHANIC_SHIELD");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_SHIELD;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_BANISH) {
                        tipos.Add("MECHANIC_BANISH");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_BANISH;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_POLYMORPH) {
                        tipos.Add("MECHANIC_POLYMORPH");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_POLYMORPH;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_BANDAGE) {
                        tipos.Add("MECHANIC_BANDAGE");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_BANDAGE;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_BLEED) {
                        tipos.Add("MECHANIC_BLEED");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_BLEED;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_KNOCKOUT) {
                        tipos.Add("MECHANIC_KNOCKOUT");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_KNOCKOUT;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_FREEZE) {
                        tipos.Add("MECHANIC_FREEZE");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_FREEZE;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_STUN) {
                        tipos.Add("MECHANIC_STUN");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_STUN;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_SNARE) {
                        tipos.Add("MECHANIC_SNARE");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_SNARE;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_SLEEP) {
                        tipos.Add("MECHANIC_SLEEP");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_SLEEP;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_SILENCE) {
                        tipos.Add("MECHANIC_SILENCE");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_SILENCE;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_PACIFY) {
                        tipos.Add("MECHANIC_PACIFY");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_PACIFY;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_ROOT) {
                        tipos.Add("MECHANIC_ROOT");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_ROOT;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_GRIP) {
                        tipos.Add("MECHANIC_GRIP");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_GRIP;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_FEAR) {
                        tipos.Add("MECHANIC_FEAR");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_FEAR;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_DISTRACT) {
                        tipos.Add("MECHANIC_DISTRACT");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_DISTRACT;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_DISARM) {
                        tipos.Add("MECHANIC_DISARM");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_DISARM;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_DISORIENTED) {
                        tipos.Add("MECHANIC_DISORIENTED");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_DISORIENTED;
                    }
                    if(numero >= (int)mechanic_immune_mask.MECHANIC_CHARM) {
                        tipos.Add("MECHANIC_CHARM");
                        numero = numero - (int)mechanic_immune_mask.MECHANIC_CHARM;
                    }


                    tipos.Reverse();
                    texto = "";
                    foreach(string mechanic in tipos) {
                        texto = texto + mechanic + "\r\n";
                    }


                    textBox1.Text = texto;
                    break;
            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (Char)13) {
                btCalcular.PerformClick();
            }
            /*
            switch(e.KeyChar) {
                case (char)8:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case (char)',':
                case (char)'.': break;
                default:
                    e.KeyChar = (char)0;
                    break;
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e) {
            cbTipos.SelectedItem = cbTipos.Items[0];
        }

        private void cbTipos_SelectedIndexChanged(object sender, EventArgs e) {
            tipoSeleccionado = cbTipos.SelectedItem.ToString();
        }
    }
}
