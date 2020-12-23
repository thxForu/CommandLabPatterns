const eventFactory = require("./eventFactory");

const myEvent1 = eventFactory.createEvent({
    date: new Date(1969, 7, 21),
    description: "Apollo 11 Astronauts Land on the Moon",
    lang: "en",
    url: "https://en.wikipedia.org/wiki/Apollo_11"
});

const myEvent2 = eventFactory.createEvent({
    date: new Date(1961, 4, 12),
    description: "Yuri Gagarin Becomes the First Man in Space",
    lang: "ua",
    url: "https://en.wikipedia.org/wiki/Vostok_1"
});

const myEvent3 = eventFactory.createEvent({
    date: new Date(1957, 10, 4),
    description: "Soviet Union Launches Sputnik, First Man-Made Satellite",
    url: "https://en.wikipedia.org/wiki/Sputnik_1"
});

console.log(myEvent1,"\n", myEvent2, "\n", myEvent3);