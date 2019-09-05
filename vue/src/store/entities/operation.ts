import Entity from './entity'
import { DatePicker } from '../../types/iview/date-picker';
export default class Operation extends Entity<number>{
    date: DatePicker;
    commodity: string;
    destiny: string;
}