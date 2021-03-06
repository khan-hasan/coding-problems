"""
https://www.codewars.com/kata/human-readable-duration-format/train/python

Difficulty: 4 kyu

Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.

The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.

It is much easier to understand with an example:

format_duration(62)    # returns "1 minute and 2 seconds"
format_duration(3662)  # returns "1 hour, 1 minute and 2 seconds"
For the purpose of this Kata, a year is 365 days and a day is 24 hours.

Note that spaces are important.

Detailed rules
The resulting expression is made of components like 4 seconds, 1 year, etc. In general, a positive integer and one of the valid units of time, separated by a space. The unit of time is used in plural if the integer is greater than 1.

The components are separated by a comma and a space (", "). Except the last component, which is separated by " and ", just like it would be written in English.

A more significant units of time will occur before than a least significant one. Therefore, 1 second and 1 year is not correct, but 1 year and 1 second is.

Different components have different unit of times. So there is not repeated units like in 5 seconds and 1 second.

A component will not appear at all if its value happens to be zero. Hence, 1 minute and 0 seconds is not valid, but it should be just 1 minute.

A unit of time must be used "as much as possible". It means that the function should not return 61 seconds, but 1 minute and 1 second instead. Formally, the duration specified by of a component must not be greater than any valid more significant unit of time.

ALGORITHMS, FORMATS, STRINGS, DATES/TIME, FORMATTING
"""

def format_duration(seconds: int) -> str:
    """
    Convert a given number of seconds to a human-readable time duration format.

    :seconds: time in number of seconds
    :type seconds: int

    :returns: a human-readable time duration in str format
    :rtype: str
    """

    if not seconds:
        return 'now'

    time_components = {
        'years': 0,
        'days': 0,
        'hours': 0,
        'minutes': 0,
        'seconds': 0
    }

    SEC_IN_YEAR = 60*60*24*365
    years, seconds_remaining = divmod(seconds, SEC_IN_YEAR)
    time_components['years'] = years
    
    SEC_IN_DAY = 60*60*24
    days, seconds_remaining = divmod(seconds_remaining, SEC_IN_DAY)
    time_components['days'] = days

    SEC_IN_HOUR = 60*60
    hours, seconds_remaining = divmod(seconds_remaining, SEC_IN_HOUR)
    time_components['hours'] = hours

    SEC_IN_MINUTE = 60
    minutes, seconds_remaining = divmod(seconds_remaining, SEC_IN_MINUTE)
    time_components['minutes'] = minutes

    time_components['seconds'] = seconds_remaining

    formatted_times = []
    for time_component, value in time_components.items():
        if not value:
            continue
        if value == 1:
            formatted_times.append(f'{value} {time_component}'[:-1])
        else:
            formatted_times.append(f'{value} {time_component}')

    formatted_duration = ', '.join(formatted_times[:-1]) + f' and {formatted_times[-1]}'

    return formatted_duration


print(format_duration(62))