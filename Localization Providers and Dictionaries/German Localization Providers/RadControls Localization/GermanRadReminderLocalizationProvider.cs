﻿using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanRadReminderLocalizationProvider : RadReminderLocalizationProvider
    {
        public override string GetLocalizedString( string id )
        {
            switch ( id )
            {
                case RadReminderStringId.AlarmFormButtonDismiss:
                    return "Schließen";
                case RadReminderStringId.AlarmFormButtonDismissAll:
                    return "Alle schließen";
                case RadReminderStringId.AlarmFormButtonOpenItem:
                    return "Element öffnen";
                case RadReminderStringId.AlarmFormButtonSnooze:
                    return "Erneut erinnern";
                case RadReminderStringId.AlarmFormColumnDueIn:
                    return "Fällig in";
                case RadReminderStringId.AlarmFormColumnSubject:
                    return "Betreff";
                case RadReminderStringId.AlarmFormLabelSnooze:
                    return "Klicken Sie auf \"Erneut erinnern\", um nach Ablauf des unten gewählten Zeitraums erneut erinnert zu werden.";
                case RadReminderStringId.AlarmFormReminder:
                    return "Erinnerung";
                case RadReminderStringId.AlarmFormReminders:
                    return "Ernnerungen";
				case RadReminderStringId.AlarmFormSnoozeOneMinute:
					return "1 Minute";
				case RadReminderStringId.AlarmFormSnoozeFiveMinutes:
					return "5 Minuten";
				case RadReminderStringId.AlarmFormSnoozeTenMinutes:
					return "10 Minuten";
				case RadReminderStringId.AlarmFormSnoozeFifteenMinutes:
					return "15 Minuten";
				case RadReminderStringId.AlarmFormSnoozeThirtyMinutes:
					return "30 Minuten";
				case RadReminderStringId.AlarmFormSnoozeOneHour:
					return "1 Stunde";
				case RadReminderStringId.AlarmFormSnoozeTwoHours:
					return "2 Stunden";
				case RadReminderStringId.AlarmFormSnoozeFourHours:
					return "4 Stunden";
				case RadReminderStringId.AlarmFormSnoozeEightHours:
					return "8 Stunden";
				case RadReminderStringId.AlarmFormSnoozeHalfDay:
					return "0,5 Tage";
				case RadReminderStringId.AlarmFormSnoozeOneDay:
					return "1 Tag";
				case RadReminderStringId.AlarmFormSnoozeTwoDays:
					return "2 Tage";
				case RadReminderStringId.AlarmFormSnoozeThreeDays:
					return "3 Tage";
				case RadReminderStringId.AlarmFormSnoozeFourDays:
					return "4 Tage";
				case RadReminderStringId.AlarmFormSnoozeOneWeek:
					return "1 Woche";
				case RadReminderStringId.AlarmFormSnoozeTwoWeeks:
					return "2 Wochen";
				case RadReminderStringId.DueInMinute:
					return "Minute fällig";
				case RadReminderStringId.DueInMinutes:
					return "Minuten fällig";
				case RadReminderStringId.DueInHour:
					return "Stunde fällig";
				case RadReminderStringId.DueInHours:
					return "Stunden fällig";
				case RadReminderStringId.DueInDay:
					return "Tag fällig";
				case RadReminderStringId.DueInDays:
					return "Tagen fällig";
				case RadReminderStringId.DueInWeek:
					return "Woche fällig";
				case RadReminderStringId.DueInWeeks:
					return "Wochen fällig";
				case RadReminderStringId.DueInNow:
					return "Jetzt";
				case RadReminderStringId.DueInOverdue:
					return "seit {0}";
				case RadReminderStringId.AlarmFormSelectMoreRemindObjects:
                    return " Erinnerungen sind ausgewählt.";
                default:
                    MessageBox.Show( string.Format( "GermanRadReminderLocalizationProvider: Missing Translation for: {0}" , id ) );
                    break;
            }

            return String.Empty;
        }
    }
}