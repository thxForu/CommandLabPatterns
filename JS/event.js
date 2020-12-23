const Event = function({ date, description, lang, url }) {
    this.date = date.getDate() + "." + (date.getMonth()) + "." + date.getFullYear();
    this.description = description || "";
    this.serviceMessage = (lang == "en") ? ("Service Message") : ((lang == "ua") ? ("Службова повідомлення") : (""))
    this.url = url || "";
  };
  module.exports = Event;