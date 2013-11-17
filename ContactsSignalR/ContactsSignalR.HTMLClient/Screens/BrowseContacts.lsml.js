/// <reference path="../GeneratedArtifacts/viewModel.js" />
/// <reference path="../Scripts/jquery.signalR-2.0.0.js" />



myapp.BrowseContacts.created = function (screen) {
    // Write code here.
    screen.updates = "Browse Contacts Screen Created";

    $(function () {

        contact = $.connection.contactHub;
        contact.client.broadcastMessage = function (message) {
            screen.updates = message;
        };

        $.connection.hub.start()
        .done(function () {
        })
        .fail(function () {
            alert("Could not Connect! - ensure EnableCrossDomain = true");
        });
    });
};