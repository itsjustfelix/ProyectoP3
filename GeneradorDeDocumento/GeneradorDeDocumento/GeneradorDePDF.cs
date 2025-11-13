using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;

namespace GeneradorDeDocumento
{
    public abstract class GeneradorDePDF<T> : IDocument
    {
        public string rutaDeGuardado;
        public byte[] logo;
        public GeneradorDePDF(string nombreCarpeta, string rutaLogo)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            rutaDeGuardado = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreCarpeta);
            if (!Directory.Exists(rutaDeGuardado))
                Directory.CreateDirectory(rutaDeGuardado);
            this.logo = File.ReadAllBytes(rutaLogo);
        }
        public abstract string GenerarPDF();
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public abstract void Compose(IDocumentContainer container);
        public  DocumentSettings GetSettings() => DocumentSettings.Default;
    }
}
