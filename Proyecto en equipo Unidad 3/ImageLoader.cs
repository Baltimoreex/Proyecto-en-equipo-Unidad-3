using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_en_equipo_Unidad_3
{
    public static class ImageLoader
    {
        
        private const string EXT = ".png";

        public static Image Cargar(string subcarpeta, string nombreArchivo)
        {
            string ruta = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Images",
                subcarpeta,
                nombreArchivo + EXT
            );

            if (!File.Exists(ruta)) return null;

            try
            {
                byte[] bytes = File.ReadAllBytes(ruta);
                using var ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            catch { return null; }
        }

        public static void MostrarEn(PictureBox pic, string subcarpeta, string nombreArchivo)
        {
            
            Image anterior = pic.Image;
            pic.Image = null;
            anterior?.Dispose();

            pic.Image = Cargar(subcarpeta, nombreArchivo);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
