using System;
using System.Linq;
using System.Windows.Forms;
using wishApp.Controller;
using wishApp.Model;

namespace wishApp
{
    public partial class NewWish : Form
    {
        private readonly WishController controller;
        private readonly int modelID;
        public NewWish(WishController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        public NewWish(WishController controller, WishModel model) : this(controller)
        {
            modelID = model.ID;
            nameTextBox.Text = model.Name;
            ageNumericUpDown.Value = model.Age;
            wishTextBox.Text = model.Wish;
            amountNumericUpDown.Value = model.Amount;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string Name = nameTextBox.Text;
            int Age = (int)ageNumericUpDown.Value;
            string Wish = wishTextBox.Text;
            int Amount = (int)amountNumericUpDown.Value;

            if (Name == string.Empty)
            {
                {
                    MessageBox.Show("Nem adtál meg nevet!", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (Age < 2 || Age > 200)
            {
                MessageBox.Show("Nem adtál meg érvényes életkort!", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Amount < 0 || Amount > 9001)
            {
                MessageBox.Show("Nem adtál meg érvényes összeget!", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Wish == string.Empty)
            {
                MessageBox.Show("Nem adtál meg kívánságot!", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (controller.GetWishModels().Any(x => x.Name == Name))
            {
                MessageBox.Show("Már létezik ilyen nevű kívánság!", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WishModel model = new WishModel { Name = Name, Age = Age, Wish = Wish, Amount = Amount };



            controller.AddWish(model);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
