using System.Windows.Forms;

namespace ETS2Trax {

    public enum Game {
        ETS2, ATS
    }

    public partial class TMBForm : Form {
        public TMBForm() {
            InitializeComponent();

            ets2LibraryTab.InitializeForGame(Game.ETS2);
            atsLibraryTab.InitializeForGame(Game.ATS);
            

        }
    }
}
