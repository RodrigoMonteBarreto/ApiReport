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
    public class RelatoriosProdutosController : ControllerBase
    {

        private readonly MyContext _context;

        public RelatoriosProdutosController(MyContext context)
        {
            _context = context;
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


        [HttpGet("FichaProduto/{EAN}")]
        public ActionResult GetFichaProduto([FromRoute][Required] string EAN)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("FichaProduto.frx");

            var produtoList = _context.Produtos.Where(p => p.Ean.Equals(EAN)).ToList();
            var empresaList = _context.Empresas.ToList();

            var produtos = HelpFastReport.GetTable<ProdutoEntity>(produtoList, "Produtos");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(produtos, "Produtos");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", $"FichaProdutoPorEAN_{EAN}.pdf");

        }

        [HttpGet("FichaProdutoPorID/{id}")]
        public ActionResult GetFichaProdutoPorID([FromRoute][Required] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("FichaProduto.frx");

            var produtoList = _context.Produtos.Where(p => p.Id == id).ToList();
            var empresaList = _context.Empresas.ToList();

            var produtos = HelpFastReport.GetTable<ProdutoEntity>(produtoList, "Produtos");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");

            webReport.Report.RegisterData(produtos, "Produtos");
            webReport.Report.RegisterData(empresa, "Empresas");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", $"FichaProdutoPorId_{id.ToString()}.pdf");

        }

        [HttpGet("ProdutoPorCategoria")]
        public ActionResult GetProdutoPorCategoria()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("ListagemProdutosCategoria.frx");

            var produtoList = _context.Produtos.ToList();
            var empresaList = _context.Empresas.ToList();
            var categoriaList = _context.Categorias.ToList();

            var produtos = HelpFastReport.GetTable<ProdutoEntity>(produtoList, "Produtos");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");
            var categoria = HelpFastReport.GetTable<CategoriaEntity>(categoriaList, "Categorias");

            webReport.Report.RegisterData(produtos, "Produtos");
            webReport.Report.RegisterData(empresa, "Empresas");
            webReport.Report.RegisterData(categoria, "Categorias");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "ListagemProdutoCategoria.pdf");

        }

        [HttpGet("ProdutoPorCategoria/{id}")]
        public ActionResult GetProdutoPorCategoria([FromRoute][Required] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var webReport = HelpFastReport.webReport("ListagemProdutosCategoria.frx");

            var produtoList = _context.Produtos.Where(p => p.CategoriaId == id).ToList();
            var empresaList = _context.Empresas.ToList();
            var categoriaList = _context.Categorias.Where(c => c.Id == id).ToList();

            var produtos = HelpFastReport.GetTable<ProdutoEntity>(produtoList, "Produtos");
            var empresa = HelpFastReport.GetTable<EmpresaEntity>(empresaList, "Empresas");
            var categoria = HelpFastReport.GetTable<CategoriaEntity>(categoriaList, "Categorias");

            webReport.Report.RegisterData(produtos, "Produtos");
            webReport.Report.RegisterData(empresa, "Empresas");
            webReport.Report.RegisterData(categoria, "Categorias");

            return File(HelpFastReport.ExportarPdf(webReport), "application/pdf", "ListagemProdutoCategoria.pdf");

        }

    }
}