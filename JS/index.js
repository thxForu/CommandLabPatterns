import {Event} from './Fabric';

const factory = new Event()
var eDate = factory.create('Event date')
var eDescription = factory.create('Description')
var eUrl = factory.create('URL')

eDate.say()
eDescription.say()
eUrl.say()