const Event = require("./event");

module.exports = {
    createEvent(attributes) {
        const EventType = Event;
        return new EventType(attributes);
    }
};