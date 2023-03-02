$(document).ready(function () {
    $("#selected-plays > li").addClass("horizontal");
    $("#selected-plays > li:not(.horizontal)").addClass("sub-level");
    $("a[href^='mailto:']").addClass("mailto");
    $("a[href$='.pdf']").addClass("pdflink");
    $("a[href^='http']").addClass("henrylink");
    $("tr:nth-child(odd)").addClass("alt");
    $("tr:contains(Hanry)").addClass("highlight");
});  

