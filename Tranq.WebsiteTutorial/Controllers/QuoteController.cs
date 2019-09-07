using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tranq.WebsiteTutorial.Models;
using Tranq.WebsiteTutorial.Services;
using Tranq.WebsiteTutorial.Translators;

namespace Tranq.WebsiteTutorial.Controllers
{
    public class QuoteController : Controller
    {
        private readonly IQuoteService _quoteService;

        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        // GET: Quotes
        public ActionResult Index()
        {
            var quotes = _quoteService.GetQuotes().ToList();

            var translatedQuotes = quotes.Select(quote => quote.Translate());
            return View(translatedQuotes);
        }

        // GET: Quotes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quotes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateQuoteViewModel model)
        {
            try
            {
                _quoteService.CreateQuote(model.PersonName, model.QuoteContent);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Quotes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quotes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Quotes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quotes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}