using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using ApiFastReport.Data;
using ApiFastReport.Entity;
using ApiFastReport.Helpers;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Mvc;

namespace ApiFastReport.Controllers
{
    public class RelatoriosUsuarioController : ControllerBase
    {

        private readonly MyContext _context;

        public RelatoriosUsuarioController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("ListagemUsuarioSimples")]
        public ActionResult GetListagemUsuarioSimples()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("ListagemUsuarios.frx");

            var UsuarioList = _context.Usuarios.Where(x => x.Nome != "").ToList();
            var usuarios = HelpFastReport.GetTable<UsuarioEntity>(UsuarioList, "Usuarios");

            webReport.Report.RegisterData(usuarios, "Usuarios");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "ListagemDeUsuario.pdf");
        }



        [HttpGet("ListagemUsuarioComCabecalho")]
        public ActionResult GetListagemUsuarioComCabecalho()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("ListagemUsuariosComCabecalho.frx");

            var UsuarioList = _context.Usuarios.Where(x => x.Nome != "").ToList();
            var empresaList = _context.Empresas.ToList();

            var usuarios = HelpFastReport.GetTable<UsuarioEntity>(UsuarioList, "Usuarios");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(usuarios, "Usuarios");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "ListagemUsuariosComCabecalho.pdf");
        }


    }
}