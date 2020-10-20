class EventDate {
    constructor () {
        var date = new Date(2020, 10, 25)
        this.value = date.getDate()  + "." + (date.getMonth()) + "." + date.getFullYear()
    }
}
  
class Description {
    constructor (lang) {
        if(lang == 'en'){
            this.value = 'Ukrainian local elections '
        }
        else if(lang == 'ua'){
            this.value = 'Місцеві вибори в Україні'
        }
        else this.value = 'Language is not supported'
    }
}
  
class URL {
    constructor () {
        this.value = 'https://www.cvk.gov.ua/vibory_category/mistsevi-vibori.html'
    }
}


class Event {
    create(datatype, lang) {
        let event
        if (datatype === 'Event date') {
            event = new EventDate()
        } else if (datatype === 'Description') {
            event = new Description(lang)
        } else if (datatype === 'URL') {
            event = new URL()
        } else console.log('Incorrect datatype')
        event.datatype = datatype
        event.say = function () {
            console.log(`${this.datatype}:  ${this.value}`)
        }
        return event
    }
}

export {Event}