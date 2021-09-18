using System;
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
    public class RelatorioVendaController : ControllerBase
    {
        private readonly MyContext _context;

        public RelatorioVendaController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("ListagemVendasPorCliente/{DataInicio}/{DataFim}")]
        public ActionResult GetListagemVendasCliente([FromRoute][Required] DateTime DataInicio, [FromRoute][Required] DateTime DataFim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("VendasPorCliente.frx");

            var clientesList = _context.Clientes.ToList();
            var vendaList = _context.Vendas.Where(v => v.DataVenda >= DataInicio && v.DataVenda <= DataFim).ToList();
            var empresaList = _context.Empresas.ToList();

            var clientes = HelpFastReport.GetTable<ClienteEntity>(clientesList, "Produtos");
            var vendas = HelpFastReport.GetTable<VendaEntity>(vendaList, "Vendas");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(clientes, "Produtos");
            webReport.Report.RegisterData(vendas, "Vendas");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "VendasPorCliente.pdf");

        }

        [HttpGet("ListagemVendasPorData/{DataInicio}/{DataFim}")]
        public ActionResult GetListagemVendasData([FromRoute][Required] DateTime DataInicio, [FromRoute][Required] DateTime DataFim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("VendasPorData.frx");

            var clientesList = _context.Clientes.ToList();
            var vendaList = _context.Vendas.Where(v => v.DataVenda >= DataInicio && v.DataVenda <= DataFim).ToList();
            var empresaList = _context.Empresas.ToList();

            var clientes = HelpFastReport.GetTable<ClienteEntity>(clientesList, "Produtos");
            var vendas = HelpFastReport.GetTable<VendaEntity>(vendaList, "Vendas");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(clientes, "Produtos");
            webReport.Report.RegisterData(vendas, "Vendas");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "VendasPorData.pdf");

        }

    }
}