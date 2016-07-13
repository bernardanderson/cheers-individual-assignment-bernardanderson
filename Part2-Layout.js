Get the user input for the current month/year.
Use a regex to see if the input contains mm/dd format.
Split into two parts mm and dd on "/".
Get current month and day
Convert current month and day into number of days in the year.
Convert user birth month into days in year and add birth day to that value.
See if current day is less than or greater than user birth year-day value.

If cday > bday then subtract bday from cday and that is your answer.
If cday < bday  then subtract cday from 365 and add the result to bday and that is your answer. 


