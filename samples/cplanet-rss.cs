<?xml version="1.0" encoding="UTF-8"?>
<rss version="2.0">
	<channel>
		<title><?cs var:CPlanet.Name ?></title>
		<link><?cs var:CPlanet.URL ?></link>
		<description><?cs var:CPlanet.Description ?></description>
		 <language>en</language>
		 <generator>CPlanet <?cs var:CPlanet.Version ?></generator>
		 <lastBuildDate><?cs var:CPlanet.GenerationDateRFC822 ?></lastBuildDate>
		 <?cs each:post = CPlanet.Posts ?>
		 <item>
			 <title><?cs var:post.FeedName ?> &gt; <![CDATA[<?cs var:post.Title ?>]]></title>
			 <description><![CDATA[<?cs var:post.Description ?>]]></description>
			 <link><?cs var:post.Link ?></link>
			 <guid><?cs var:post.Link ?></guid>
			 <?cs each:tags = post.Tags ?>
			 <category><?cs var:tags.Tag ?></category>
			 <?cs /each ?>
			 <pubDate><?cs var:post.DateRFC822 ?></pubDate>
		 </item>
		 <?cs /each ?>
	</channel>
</rss>
