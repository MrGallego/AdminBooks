﻿namespace AdminBooks.Data.Models.Response
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AccessInfo
    {
        public string? country { get; set; }
        public string? viewability { get; set; }
        public bool embeddable { get; set; }
        public bool publicDomain { get; set; }
        public string? textToSpeechPermission { get; set; }
        public Epub? epub { get; set; }
        public Pdf? pdf { get; set; }
        public string? webReaderLink { get; set; }
        public string? accessViewStatus { get; set; }
        public bool quoteSharingAllowed { get; set; }
    }

    public class Epub
    {
        public bool isAvailable { get; set; }
    }

    public class IndustryIdentifier
    {
        public string? type { get; set; }
        public string? identifier { get; set; }
    }

    public class Item
    {
        public string? kind { get; set; }
        public string? id { get; set; }
        public string? etag { get; set; }
        public string? selfLink { get; set; }
        public VolumeInfo? volumeInfo { get; set; }
        public SaleInfo? saleInfo { get; set; }
        public AccessInfo? accessInfo { get; set; }
        public SearchInfo? searchInfo { get; set; }
    }

    public class PanelizationSummary
    {
        public bool containsEpubBubbles { get; set; }
        public bool containsImageBubbles { get; set; }
    }

    public class Pdf
    {
        public bool isAvailable { get; set; }
    }

    public class ReadingModes
    {
        public bool text { get; set; }
        public bool image { get; set; }
    }

    public class BooksResponse
    {
        public string? kind { get; set; }
        public int totalItems { get; set; }
        public List<Item>? items { get; set; }
    }

    public class SaleInfo
    {
        public string? country { get; set; }
        public string? saleability { get; set; }
        public bool isEbook { get; set; }
    }

    public class SearchInfo
    {
        public string? textSnippet { get; set; }
    }

    public class VolumeInfo
    {
        public string? title { get; set; }
        public List<string>? authors { get; set; }
        public string? publishedDate { get; set; }
        public List<IndustryIdentifier>? industryIdentifiers { get; set; }
        public ReadingModes? readingModes { get; set; }
        public int pageCount { get; set; }
        public string? printType { get; set; }
        public List<string>? categories { get; set; }
        public string? maturityRating { get; set; }
        public bool allowAnonLogging { get; set; }
        public string? contentVersion { get; set; }
        public string? language { get; set; }
        public string? previewLink { get; set; }
        public string? infoLink { get; set; }
        public string? canonicalVolumeLink { get; set; }
        public string? subtitle { get; set; }
        public PanelizationSummary? panelizationSummary { get; set; }
    }



}
