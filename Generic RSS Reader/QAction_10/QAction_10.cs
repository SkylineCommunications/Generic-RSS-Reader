using System;
using System.Collections.Generic;
using System.Globalization;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;

using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: Read RSS.
/// </summary>
public static class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocolExt protocol)
	{
		try
		{
			string rssFeedUrl = Convert.ToString(protocol.Rssfeedurl);
			if (string.IsNullOrEmpty(rssFeedUrl))
			{
				return;
			}

			SyndicationFeed feed = null;

			try
			{
				using (var reader = XmlReader.Create(rssFeedUrl))
				{
					feed = SyndicationFeed.Load(reader);
				}
			}
			catch { } // TODO: Deal with unavailable resource.

			if (feed == null)
			{
				return;
			}

			List<QActionTableRow> rows = new List<QActionTableRow>();
			foreach (var element in feed.Items)
			{
				RssfeedoverviewQActionRow row = new RssfeedoverviewQActionRow
				{
					Rssfeedoverviewinstance = element.Id,
					Rssfeedoverviewtitle = element.Title.Text,
					Rssfeedoverviewsummary = element.Summary.Text,
				};

				rows.Add(row);
			}

			protocol.rssfeedoverview.FillArray(rows);
		}
		catch (Exception ex)
		{
			protocol.Log("QA" + protocol.QActionID + "|" + protocol.GetTriggerParameter() + "|Run|Exception thrown:" + Environment.NewLine + ex, LogType.Error, LogLevel.NoLogging);
		}
	}
}