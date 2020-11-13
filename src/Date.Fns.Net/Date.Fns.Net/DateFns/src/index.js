import { formatDistance } from 'date-fns';
import { formatDistanceToNow } from 'date-fns';
import { formatDistanceStrict } from 'date-fns';
import { formatDistanceToNowStrict } from 'date-fns';

export function FormatDistance(date, baseDate, options) {
    const dateObject = new Date(date);
    const baseDateObject = new Date(baseDate);
    return formatDistance(dateObject, baseDateObject, options);
}

export function FormatDistanceToNow(date, options) {
    const dateObject = new Date(date);
    return formatDistanceToNow(dateObject, options);
}

export function FormatDistanceStrict(date, baseDate, options){
    const dateObject = new Date(date);
    const baseDateObject = new Date(baseDate);
    return formatDistanceStrict(dateObject, baseDateObject, options);
}

export function FormatDistanceToNowStrict(date, options) {
    const dateObject = new Date(date);
    return formatDistanceToNowStrict(dateObject, options);
}