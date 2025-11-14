using System;
using System.IO;
using Entidad;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GeneradorDeDocumento
{
    public class GeneradorDePDFConsultas : GeneradorDePDF<Consulta>
    {
        public Consulta entidad;

        public GeneradorDePDFConsultas(string nombreCarpeta, string rutaLogo, Consulta entidad) : base(nombreCarpeta, rutaLogo)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            this.rutaDeGuardado = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreCarpeta);
            if (!Directory.Exists(rutaDeGuardado)) Directory.CreateDirectory(rutaDeGuardado);
            this.logo = File.ReadAllBytes(rutaLogo);
            this.entidad = entidad;
        }

        public override void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Size(PageSizes.Letter);
                page.PageColor(Colors.White);
                page.Header().Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().Text("Veterinaria MY VET").Bold().FontSize(16).AlignCenter();
                        col.Item().Text("Historial Clinico").FontSize(12).FontColor(Colors.Grey.Medium).AlignCenter();

                    });
                    // Si quieres mostrar la imagen, pásale el array de bytes
                    row.ConstantItem(80).Image(logo);
                });
                page.Content().Column(col =>
                {
                    // --- Sección 1: fila con datos generales ---
                    col.Item().Row(row =>
                    {
                        row.RelativeItem().Column(c1 =>
                        {
                            c1.Item().Text($"Código consulta: {entidad.Codigo}").AlignLeft();
                            c1.Item().Text($"Fecha documento: {DateTime.Now:dd/MM/yyyy}").AlignLeft();
                            c1.Item().Text($"Fecha consulta: {entidad.Fecha}").AlignLeft();
                        });

                        row.RelativeItem().Column(c2 =>
                        {
                            c2.Item().Text($"Nombre mascota: {entidad.Mascota.Nombre}").AlignLeft();
                            c2.Item().Text($"Especie: {entidad.Mascota.Especie.Nombre}").AlignLeft();
                            c2.Item().Text($"Raza: {entidad.Mascota.Raza.Nombre}").AlignLeft();
                            c2.Item().Text($"Nombre Veterinario: {entidad.Veterinario.Nombres}").AlignLeft();
                            c2.Item().Text($"Especializacion: {entidad.Veterinario.Especializacion.Nombre}").AlignLeft();
                        });
                    });

                    // --- Espacio separador ---
                    col.Item().PaddingVertical(10).LineHorizontal(1).LineColor(Colors.Grey.Medium);

                    col.Item().Text("Descripcion del propietario:")
                        .Bold()
                        .FontSize(14)
                        .AlignLeft();

                    col.Item().Text($"{entidad.Descripcion}")
                        .FontSize(12)
                        .AlignLeft();

                    // --- Sección 2: texto normal debajo ---
                    col.Item().Text("Motivo de la consulta:")
                        .Bold()
                        .FontSize(14)
                        .AlignLeft();

                    col.Item().Text($"{entidad.Diagnostico}")
                        .FontSize(12)
                        .AlignLeft();

                    // --- Puedes seguir agregando más secciones ---
                    col.Item().PaddingTop(10).Text("Observaciones del veterinario:")
                        .Bold()
                        .FontSize(14)
                        .AlignLeft();

                    col.Item().Text($"{entidad.Tratamiento}")
                        .FontSize(12)
                        .AlignLeft();
                });


                page.Footer()
                .AlignCenter()
                .Text(x =>
                {
                    x.Span("Pagina");
                    x.CurrentPageNumber();
                    x.Span(" de ");
                    x.TotalPages();
                });


            });
        }

        public override string GenerarPDF()
        {
            try
            {
                var nombreArchivo = $"Consulta_{entidad.Codigo}_{entidad.Mascota.Nombre}.pdf";
                var filePath = Path.Combine(rutaDeGuardado,nombreArchivo);
                var document = this;
                document.GeneratePdf(filePath);
                return filePath;
            }
            catch (Exception e)
            {
                throw new Exception($"hubo un error en la capa de generacion de pdf --> {e.Message}");
            }
            
        }
    }
}
