import {Event} from './Fabric';

var lang
let n = Math.floor( Math.random() * 2 )
if (n == 1){
    lang = 'en';
}
else lang = 'ua'

const factory = new Event()
var eDate = factory.create('Event date')
var eDescription = factory.create('Description', lang)
var eUrl = factory.create('URL')

eDate.say()
eDescription.say()
eUrl.say()