namespace Proyecto_en_equipo_Unidad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Player jugador;


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var perfil in Player.ObtenerPerfiles())
                cmbPlayers.Items.Add(perfil.Nombre);

            cmbPlayers.SelectedIndex = -1;

            cmbWeapons.Items.Insert(0, "Selecciona un arma...");
            cmbWeapons.Items.Add("AWP");
            cmbWeapons.Items.Add("Glock-18");
            cmbWeapons.Items.Add("M4A1");
            cmbWeapons.Items.Add("MAC-10");
            cmbWeapons.Items.Add("MP9");
            cmbWeapons.Items.Add("USP");

            cmbWeapons.SelectedIndex = 0;

            PasoArmas(false);
            PasoAcciones(false);
        }



        private void cmbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var perfiles = Player.ObtenerPerfiles();
            jugador = perfiles[cmbPlayers.SelectedIndex];

            lblName2.Text = jugador.Nombre;
            lblRange2.Text = jugador.Rango;
            lblLevel2.Text = "Nivel " + jugador.Nivel;

            if (jugador.Avatar != null)
            {
                picAvatar.Image = jugador.Avatar;
                picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                picAvatar.Refresh();
            }
            else
            {
                MessageBox.Show("Imagen no encontrada. Verifica que estén en la carpeta ProfileImage y configuradas como 'Copiar siempre'.");
            }

            PasoArmas(true);
            PasoAcciones(false);
        }
        private void MostrarImagenArma(string nombreArma)
        {
            string[] extensiones = { ".png", ".jpg", ".jpeg" };

            foreach (string ext in extensiones)
            {
                string ruta = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Images",
                    "Weapons_Images",
                    nombreArma + ext
                );

                if (File.Exists(ruta))
                {
                    try
                    {
                       
                        Image anterior = picWeapons.Image;
                        picWeapons.Image = null;
                        anterior?.Dispose();

                        
                        byte[] bytes = File.ReadAllBytes(ruta);
                        using var ms = new MemoryStream(bytes);
                        picWeapons.Image = Image.FromStream(ms);
                        picWeapons.SizeMode = PictureBoxSizeMode.Zoom;
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error cargando imagen: " + ex.Message);
                        picWeapons.Image = null;
                        return;
                    }
                }
            }

            picWeapons.Image = null;
        }
        private void cmbWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWeapons.SelectedIndex == 0)
            {
                picWeapons.Image = null;
                return;
            }

            MostrarImagenArma(cmbWeapons.SelectedItem.ToString());
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (jugador == null)
            {
                MessageBox.Show("Primero selecciona un jugador.");
                return;
            }
            if (cmbWeapons.SelectedIndex == 0)
            {
                MessageBox.Show("Selecciona un arma válida.");
                return;
            }

            WeaponComponent arma = cmbWeapons.SelectedItem.ToString() switch
            {
                "AWP" => new WeaponAWP(),
                "Glock-18" => new WeaponGlock18(),
                "M4A1" => new WeaponM4A1(),
                "MAC-10" => new WeaponMAC10(),
                "MP9" => new WeaponMP9(),
                "USP" => new WeaponUSP(),
                _ => null
            };

            if (chkScope.Checked) arma = new AttScope(arma);
            if (chkHandle.Checked) arma = new AttHandle(arma);
            if (chkExtendedMag.Checked) arma = new AttExtendedMag(arma);
            if (chkSilencer.Checked) arma = new AttSilencer(arma);

            jugador.EquiparArma(arma);

            textWeapons.Text =
                "Arma: " + arma.Nombre + "\r\n" +
                "Descripción: " + arma.Descripcion + "\r\n" +
                "Daño: " + arma.Dano + "\r\n" +
                "Precisión: " + arma.Precision + "\r\n" +
                "Precio: $" + arma.Precio;

            textShoot.Text = "";
            textReload.Text = "";
            textInspect.Text = "";

            PasoAcciones(true);
        }

        private void PasoArmas(bool activo)
        {
            cmbWeapons.Enabled = activo;
            chkScope.Enabled = activo;
            chkHandle.Enabled = activo;
            chkExtendedMag.Enabled = activo;
            chkSilencer.Enabled = activo;
            btnOrdenar.Enabled = activo;
        }

        private void PasoAcciones(bool activo)
        {
            btnShoot.Enabled = activo;
            btnReload.Enabled = activo;
            btnInspect.Enabled = activo;
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            textShoot.Text = jugador.Disparar();
            textReload.Text = "";
            textInspect.Text = "";
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            textReload.Text = jugador.Recargar();
            textShoot.Text = "";
            textInspect.Text = "";
        }

        private void btnInspect_Click(object sender, EventArgs e)
        {
            textInspect.Text = jugador.Inspeccionar();
            textReload.Text = "";
            textShoot.Text = "";

        }

       
    }
}
