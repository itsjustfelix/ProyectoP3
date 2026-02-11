using GeneradorDeDocumento.Properties;
using QuestPDF.Infrastructure;
using System;
using System.IO;

namespace GeneradorDeDocumento
{
    public abstract class GeneradorDePDF<T> : IDocument
    {
        public string rutaDeGuardado;
        public byte[] logoByte;
        public GeneradorDePDF(string nombreCarpeta, byte[] logo)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            rutaDeGuardado = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreCarpeta);
            if (!Directory.Exists(rutaDeGuardado))
                Directory.CreateDirectory(rutaDeGuardado);
            logoByte = logo;
        }
        public abstract string GenerarPDF();
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public abstract void Compose(IDocumentContainer container);
        public DocumentSettings GetSettings() => DocumentSettings.Default;
    }
}
