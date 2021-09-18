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
    public class RelatoriosClientesController : ControllerBase
    {

        private readonly MyContext _context;

        public RelatoriosClientesController(MyContext context)
        {
            _context = context;
        }



        [HttpGet("ListagemDeClientes")]
        public ActionResult GetListagemClientes()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("ListagemClientes.frx");

            var clientesList = _context.Clientes.ToList();
            var empresaList = _context.Empresas.ToList();

            var clientes = HelpFastReport.GetTable<ClienteEntity>(clientesList, "Produtos");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(clientes, "Produtos");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "ListagemClientes.pdf");

        }



        [HttpGet("FichaClienteID/{id}")]
        public ActionResult GetFichaClientePorID([FromRoute][Required] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("FichaCliente.frx");

            var clientesList = _context.Clientes.Where(x => x.Id == id).ToList();
            var empresaList = _context.Empresas.ToList();

            var clientes = HelpFastReport.GetTable<ClienteEntity>(clientesList, "Clientes");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(clientes, "Clientes");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", $"FichaClientePorID_{id.ToString()}.pdf");
        }

    }
}