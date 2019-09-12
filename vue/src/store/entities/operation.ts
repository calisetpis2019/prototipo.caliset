import Entity from './entity'
import { DatePicker } from '../../types/iview/date-picker';

export default class Operation extends Entity<number>{
    commodity: string;
    destiny: string;
    date: Date;
}