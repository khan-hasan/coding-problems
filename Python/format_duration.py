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

    # TODO: Implement algorithm
    #   1. Create a dict for time components and values
    #      ex. {'years': 0, 'weeks': 2, ...}
    #   2. Divide `seconds` by number of seconds in 1 unit of each key in dict and assign result as value in dict
    #   3. Construct str using contents of dict.
    #       - If 2+ counts, plural key
    #       - If 1 count, singular key
    #       - If 0 count, skip key

    time_components = {
        'years': 0,
        'days': 0,
        'hours': 0,
        'minutes': 0,
        'seconds': 0
    }

    # TODO: Improve logic (DRY).
    seconds_in_year = 60*60*24*365
    years, seconds_remaining = divmod(seconds, seconds_in_year)
    time_components['years'] = years
    
    seconds_in_day = 60*60*24
    days, seconds_remaining = divmod(seconds_remaining, seconds_in_day)
    time_components['days'] = days

    seconds_in_hour = 60*60
    hours, seconds_remaining = divmod(seconds_remaining, seconds_in_hour)
    time_components['hours'] = hours

    seconds_in_minute = 60
    minutes, seconds_remaining = divmod(seconds_remaining, seconds_in_minute)
    time_components['minutes'] = minutes

    time_components['seconds'] = seconds_remaining

    # TODO: Improve this.
    formatted_time = ''
    for time_component, value in time_components.items():
        if not value:
            continue
        if value == 1:
            formatted_time += f'{value}, {time_component}, '[:-1]
        else:
            formatted_time += f'{value}, {time_component}, '

    # TODO: Clean up formatted time str.
    
    return formatted_time


print(format_duration(3662))