using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace MagicTheGatheringSearchPage.Pages
{

    public class IndexModel : PageModel
    {
        public class SolrHeaderParams
        {
            public string q;
        }
        public class SolrResponseHeader
        {
            public int status;
            public int QTime;
            public SolrHeaderParams @params;
        }
        public class SolrResponse
        {
            public int numFound;
            public int start;
            public List<CardModel> docs;
        }

        public class SolrStuff
        {
            public SolrResponseHeader responseHeader;
            public SolrResponse response;
        }



       public List<String> AllowedItems;

        public class CardModel
        {
            [Display(Name = "Color Identity:")]
            public List<string> colorIdentity { get;  set; }
            [Display(Name = "Colors:")]
            public List<string> colors { get;  set; }
            [Display(Name = "Converted Mana Cost:")]
            public List<float> convertedManaCost { get;  set; }
            [Display(Name = "EDHREC:")]
            public List<int> edhrecRank { get;  set; }
            public List<string> language { get;  set; }
            public List<string> langname { get;  set; }
            [Display(Name = "Layout:")]
            public List<string> layout { get;  set; }
            public List<string> legcommander { get;  set; }
            public List<string> legduel { get;  set; }
            public List<string> leglegacy { get;  set; }
            public List<string> legpauper { get;  set; }
            public List<string> legvintage { get;  set; }
            [Display(Name = "Mana Cost:")]
            public List<string> manacost { get;  set; }
            [Display(Name = "Name:")]
            public List<string> name { get;  set; }
            [Display(Name = "Printings:")]
            public List<string> printings { get;  set; }
            [Display(Name = "Oracle ID:")]
            public List<string> scryfallOracleId { get;  set; }
            [Display(Name = "Description:")]
            public List<string> text { get;  set; }
            [Display(Name = "Type:")]
            public List<string> type { get;  set; }
            [Display(Name = "Types:")]
            public List<string> types { get;  set; }
            [Display(Name = "Unique ID:")]
            public List<string> uuid { get;  set; }
            [Display(Name = "ID:")]
            public string id { get;  set; }
            [Display(Name = "Version:")]
            public string version { get;  set; }

            string SearchItemError { get; set; }


        }


        public class CardSet
        {
            [System.ComponentModel.DataAnnotations.Display(Name = "Card Search:")]
            public string SearchItem { get; set; }
            public List<CardModel> CardInfoList { get; set; }
            public string SearchItemError { get; set; }
            public CardSet()
            {
                CardInfoList = new List<CardModel>();
            }
            public CardSet( List<CardModel> CardInfos)
            {
                CardInfoList = CardInfos;
            }
            public CardSet(params CardModel[] CardInfos)
            {
                CardInfoList = new List<CardModel>();
                foreach (var CardModel in CardInfos)
                {
                    CardInfoList.Add(CardModel);
                }
            }
        }
        [BindProperty]
        public CardSet myModel { get; set; }
        public IndexModel()
        {
            myModel = new CardSet();
            AllowedItems = new List<string>()
            {
                "Color Identity",
                "Colors",
                "Converted Mana Cost",
                "EDHREC",
                "Layout",
                "Mana Cost",
                "Name",
                "Printings",
                "Oracle ID",
                "Type",
                "Description",
                "Types",
                "Unique ID",
                "Version",
            };
        }
        public JsonResult OnPostTypeAheadImplementation(String typedstring, String QueryType)
        {
            if (typedstring == null) return new JsonResult(null);
            String Returned = "";
            try
            {
                Returned = RetrieveServerDataFromStrings(typedstring, QueryType);
            }
            catch (Exception E)
            {
                return new JsonResult(null);
            }

            List<CardModel> GoodMatches = new List<CardModel>();
            SolrStuff A = JsonConvert.DeserializeObject<SolrStuff>(Returned);
            if (!QueryType.Equals("Raw"))
            {
                foreach (CardModel Ad in A.response.docs)
                {
                    if (GoodMatches.Count < 3)
                    {
                        String toTest = getByQueryType(QueryType, Ad).Substring(0, Math.Min(getByQueryType(QueryType, Ad).Length, typedstring.Length));
                        if (toTest.ToUpper().CompareTo(typedstring.ToUpper()) == 0)// || toTest.ToUpper().CompareTo(typedstring.ToUpper()) > 0)
                        {
                            GoodMatches.Add(Ad);
                        }
                    }
                    else
                    {
                        return new JsonResult(GoodMatches);
                    }
                }
                return new JsonResult(GoodMatches);
            }
            else
            {
                A.response.docs.Sort(delegate (CardModel AC, CardModel DC)
                {
                    return AC.name[0].CompareTo(DC.name[0]);
                });
                return new JsonResult(A.response.docs);
            }
            

        }

        private string RetrieveServerDataFromStrings(string typedstring, string QueryType)
        {
            string Returned;
            WebClient myClient = new WebClient();
            if (QueryType.ToUpper().Equals("RAW"))
            {
                Returned = myClient.DownloadString("http://soft-taco.com:8983/solr/mtg/select?rows=70&q=" + typedstring.ToLower().Replace(" ", "%20") + "*");
            }
            else if (AllowedItems.Contains(QueryType))
            {
                String Result = "http://soft-taco.com:8983/solr/mtg/select?rows=150&q=" + getQueryFromHumanReadable(QueryType).ToLower().Replace(" ", "%20") + "%3A" + typedstring + "*";
                Returned = myClient.DownloadString(Result);
            }
            else
            {
                Returned = myClient.DownloadString("http://soft-taco.com:8983/solr/mtg/select?rows=150&q=name%3A" + typedstring.ToLower().Replace(" ", "%20") + "*");
            }

            return Returned;
        }

        public String getQueryFromHumanReadable(string queryType)
        {
            if (queryType.Equals("Color Identity"))
            {
                return "colorIdentity";
            }
            else if (queryType.Equals("Colors"))
            {
                return "colors";

            }
            else if (queryType.Equals("Converted Mana Cost"))
            {
                return "convertedManaCost";
            }
            else if (queryType.Equals("EDHREC"))
            {
                return "edhrecRank";
            }
            else if (queryType.Equals("Layout"))
            {
                return "layout";
            }
            else if (queryType.Equals("Mana Cost"))
            {
                return "manaCost";

            }
            else if (queryType.Equals("Name"))
            {
                return "name";

            }
            else if (queryType.Equals("Printings"))
            {
                return "printings";

            }
            else if (queryType.Equals("Oracle ID"))
            {
                return "scryfallOracleId";
            }
            else if (queryType.Equals("Type"))
            {

                return "type";
            }
            else if (queryType.Equals("Description"))
            {
                return "text";

            }
            else if (queryType.Equals("Types"))
            {
                return "types";

            }
            else if (queryType.Equals("Unique ID"))
            {
                return "uuid";

            }
            else if (queryType.Equals("Version"))
            {
                return "_version_";

            }
            return "0";
        }

        private String getByQueryType(string queryType, CardModel ad)
        {
            if (queryType.Equals("Color Identity") && ad.colorIdentity != null)
            {
                return ad.colorIdentity[0];
            }
            else if (queryType.Equals("Colors") && ad.colors != null)
            {
                return ad.colors[0];

            }
            else if (queryType.Equals("Converted Mana Cost") && ad.convertedManaCost != null)
            {
                return ad.convertedManaCost[0].ToString();
            }
            else if (queryType.Equals("EDHREC") && ad.edhrecRank != null)
            {
                return ad.edhrecRank[0].ToString();
            }
            else if (queryType.Equals("Layout") && ad.layout != null)
            {
                return ad.layout[0];
            }
            else if (queryType.Equals("Mana Cost") && ad.manacost != null)
            {
                return ad.manacost[0];

            }
            else if (queryType.Equals("Name") && ad.name != null)
            {
                return ad.name[0];

            }
            else if (queryType.Equals("Printings") && ad.printings != null)
            {
                return ad.printings[0];

            }
            else if (queryType.Equals("Oracle ID") && ad.scryfallOracleId != null)
            {
                return ad.scryfallOracleId[0];
            }
            else if (queryType.Equals("Type") && ad.type != null)
            {

                return ad.type[0];
            }
            else if (queryType.Equals("Description") && ad.text != null)
            {
                return ad.text[0];

            }
            else if (queryType.Equals("Types") && ad.types != null)
            {
                return ad.types[0];

            }
            else if (queryType.Equals("Unique ID") && ad.uuid != null)
            {
                return ad.uuid[0];

            }
            else if (queryType.Equals("Version") && ad.version != null)
            {
                return ad.version;

            }
            return "0";
        }

        public void OnGet()
        {
        }
        public void OnPostSearch(String usr, String QueryType)
        {
            if (String.IsNullOrEmpty(usr))
            {
                myModel = new CardSet();
                myModel.SearchItemError = "Invalid Search Entry, please try again.";
            }
            else
            {
                WebClient myClient = new WebClient();
                String Returned = "";
                try
                {

                Returned = RetrieveServerDataFromStrings(usr, QueryType);
                SolrStuff A = JsonConvert.DeserializeObject<SolrStuff>(Returned);
                myModel = new CardSet(A.response.docs);
                } catch(Exception E)
                {
                    myModel.SearchItemError = "Invalid Search Entry, please try again.";
                }
            }
        }
    }

}
