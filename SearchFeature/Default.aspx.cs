using System;
using Newtonsoft.Json;

public partial class _Default : System.Web.UI.Page
{
    public static string JSONString = @"{
    ""SearchItem"": [
        {
            ""ItemSearchTerm"": ""INSERT SEARCH TERM HERE"",
            ""ItemContent"": ""INSERT SEARCH DATA HERE""
        },
        {
            ""ItemSearchTerm"": ""INSERT SEARCH TERM HERE"",
            ""ItemContent"": ""INSERT SEARCH DATA HERE""
        }
    ]
}"; //Here's where you store your JSON record of the data you are searching.

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack && !string.IsNullOrWhiteSpace(SearchTextBox.Text)) //It the user has POSTed data, and filled the text box.
        {
            DisplayItems.InnerHtml = @"<p>Your Search Results:</p>"; //Clear the results div and give it a title.
            dynamic JSONObject = JsonConvert.DeserializeObject(JSONString); //create a dynamic object to hold the JSON array
            for (var Iterator = 0; Iterator < JSONObject.SearchItem.Count; Iterator++)
            {
                if (string.Equals(SearchTextBox.Text, JSONObject.SearchItem[Iterator].ItemSearchTerm.ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    DisplayItems.InnerHtml += @"<p>" 
                                            + JSONObject.SearchItem[Iterator].ItemContent.ToString() 
                                            + @"</p>"; //Insert JSON dependent content here.
                }
            }
        }
        else if (IsPostBack) //Catch if the user clears the search box.
        {
            DisplayItems.InnerHtml = @"<!-- This is where your search results turn up.  Don't add anything here. -->"; //Return the results div to it's default value.
        }
    }
}