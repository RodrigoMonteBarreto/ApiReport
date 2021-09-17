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
    public class RelatoriosController : ControllerBase
    {

        private readonly MyContext _context;

        public RelatoriosController(MyContext context)
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
            // var usuarios = new DataTable();
            // //passando colunas para o data table
            // usuarios.Columns.Add("Id", typeof(string));
            // usuarios.Columns.Add("Nome", typeof(string));
            // usuarios.Columns.Add("Email", typeof(string));
            // foreach (var item in UsuarioList)
            // {
            //     usuarios.Rows.Add(item.Id, item.Nome, item.Email);
            // }
            var usuarios = HelpFastReport.GetTable<UsuarioEntity>(UsuarioList, "Usuarios");
            // 5- Vai registrar o data table
            webReport.Report.RegisterData(usuarios, "Usuarios");

            // 10 - O file recebe o array de bytes, criar um arquivo do tipo pdf, dá o nome de:ListagemDeUsuario
            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "ListagemDeUsuario.pdf");
        }

        [HttpGet("ListagemDeProdutos")]
        public ActionResult GetListagemProdutos()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("ListagemProdutos.frx");

            var productList = _context.Produtos.ToList();
            var empresaList = _context.Empresas.ToList();

            var produtos = HelpFastReport.GetTable<ProdutoEntity>(productList, "Produtos");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(produtos, "Produtos");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "ListagemDeProdutos.pdf");

        }
        [HttpGet("ListagemDeClientes")]
        public ActionResult GetListagemClientes()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("ListagemClientes.frx.frx");

            var clientesList = _context.Clientes.ToList();
            var empresaList = _context.Empresas.ToList();

            var clientes = HelpFastReport.GetTable<ClienteEntity>(clientesList, "Produtos");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(clientes, "Produtos");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "ListagemClientes.pdf");

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