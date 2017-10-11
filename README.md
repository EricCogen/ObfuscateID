# ObfuscateID
A Utility Class For Obfuscating ID's. EX: {10025 == h0r, 1000024 == vpwq, 1000025 == vpwr} Useful For Creating Short URLS

http://sho.rt/h0r -> https://www.google.com/search?q=c%23&rlz=1C1CHZL_enUS692US692&oq=c%23&aqs=chrome..69i57j69i58j69i65l3j69i59.925j0j7&sourceid=chrome&ie=UTF-8

## Example

	string shortenedURL = ShortenURL("https://www.google.com/search?q=c%23&rlz=1C1CHZL_enUS692US692&oq=c%23&aqs=chrome..69i57j69i58j69i65l3j69i59.925j0j7&sourceid=chrome&ie=UTF-8");
	
	Response.Redirect(shortenedURL, true);

	public string ShortenURL(string inboundURL)
	{
		int myID = SaveURLToDataBase(inboundURL); //returns the primary key that was inserted;
		string shortURL = Obfuscate.Encode(myID); //returns the obfuscated value of myID; Ex: 10025 == h0r
		return $"http://sho.rt/{shortURL}"; // http://sho.rt/h0r; Instead of http://sho.rt/10025
	}
