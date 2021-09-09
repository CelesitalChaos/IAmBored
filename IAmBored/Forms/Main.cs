#region Namespaces

using System;
using System.Windows.Forms;

using IAmBored.Utilities;

#endregion

namespace IAmBored.Forms
{
    /// <summary>
    ///     The <see cref="Main" /> form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Main : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Main" /> class.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Handles the Click event of the BTN_Randomize control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void BTN_Randomize_Click(object sender, EventArgs e)
        {
            // Check for internet connectivity
            if (InternetUtilities.CheckForInternetConnection(BoredAPI.URL))
            {
                TB_Activity.Text = BoredAPI.GetModule().Activity;
                TB_Accessibility.Text = BoredAPI.GetModule().Accessibility;
                TB_Type.Text = BoredAPI.GetModule().Type;
                TB_Participants.Text = BoredAPI.GetModule().Participants;
                TB_Price.Text = BoredAPI.GetModule().Price;
                TB_Link.Text = BoredAPI.GetModule().Link;
                TB_Key.Text = BoredAPI.GetModule().Key;
            }
            else
            {
                MessageBox.Show(@"Make sure your connected to the internet.", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Handles the Load event of the Main control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            BTN_Randomize.PerformClick();
        }
    }
}