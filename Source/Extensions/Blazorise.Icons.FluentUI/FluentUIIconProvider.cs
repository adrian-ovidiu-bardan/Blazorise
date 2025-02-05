﻿#region Using directives
using System.Collections.Generic;
using System.Linq;
using Blazorise.Providers;
#endregion

namespace Blazorise.Icons.FluentUI;

class FluentUIIconProvider : BaseIconProvider
{
    #region Members

    private static Dictionary<IconName, string> names = new()
    {
        { IconName.Add, FluentUIIcons.Add },
        { IconName.Adjust, FluentUIIcons.PhotoFilter },
        { IconName.Alert, FluentUIIcons.Alert },
        { IconName.AlertOff, FluentUIIcons.AlertOff },
        { IconName.AlignCenter, FluentUIIcons.TextAlignCenter },
        { IconName.AlignJustify, FluentUIIcons.TextAlignJustify },
        { IconName.AlignLeft, FluentUIIcons.TextAlignLeft },
        { IconName.AlignRight, FluentUIIcons.TextAlignRight },
        { IconName.AngleDown, FluentUIIcons.TriangleDown },
        { IconName.AngleLeft, FluentUIIcons.TriangleLeft },
        { IconName.AngleRight, FluentUIIcons.TriangleRight},
        { IconName.AngleUp, FluentUIIcons.TriangleUp },
        { IconName.Apple, FluentUIIcons.FoodApple },
        { IconName.Archive, FluentUIIcons.Archive },
        { IconName.ArrowAltCircleDown, FluentUIIcons.ArrowCircleDown },
        { IconName.ArrowDown, FluentUIIcons.ArrowDown },
        { IconName.ArrowLeft, FluentUIIcons.ArrowLeft },
        { IconName.ArrowRight, FluentUIIcons.ArrowRight },
        { IconName.ArrowUp, FluentUIIcons.ArrowUp },
        { IconName.Baby, FluentUIIcons.FoodCarrot },
        { IconName.BabyCarriage, FluentUIIcons.VehicleBicycle },
        { IconName.Backspace, FluentUIIcons.Backspace },
        { IconName.Backward, FluentUIIcons.Rewind },
        { IconName.BalanceScale, FluentUIIcons.Scales },
        { IconName.Ban, FluentUIIcons.Warning },
        { IconName.BandAid, FluentUIIcons.BriefcaseMedical },
        { IconName.Bars, FluentUIIcons.Navigation },
        { IconName.BatteryFull, FluentUIIcons.Battery10 },
        { IconName.Bell, FluentUIIcons.Alert },
        { IconName.BellSlash, FluentUIIcons.AlertOff },
        { IconName.Biking, FluentUIIcons.VehicleBicycle },
        { IconName.BirthdayCake, FluentUIIcons.FoodCake },
        { IconName.Bold, FluentUIIcons.TextBold },
        { IconName.Bolt, FluentUIIcons.Flash },
        { IconName.Book, FluentUIIcons.Book },
        { IconName.Bookmark, FluentUIIcons.Bookmark },
        { IconName.BookReader, FluentUIIcons.ImmersiveReader },
        { IconName.BorderAll, FluentUIIcons.BorderAll },
        { IconName.BorderNone, FluentUIIcons.BorderNone },
        { IconName.BorderStyle, FluentUIIcons.BorderTopBottom },
        { IconName.Briefcase, FluentUIIcons.Briefcase },
        { IconName.Brush, FluentUIIcons.PaintBrush },
        { IconName.Bug, FluentUIIcons.Bug },
        { IconName.Building, FluentUIIcons.Building },
        { IconName.Bus, FluentUIIcons.VehicleBus },
        { IconName.Calendar, FluentUIIcons.Calendar },
        { IconName.CalendarCheck, FluentUIIcons.CalendarCheckmark },
        { IconName.CalendarDay, FluentUIIcons.CalendarDay },
        { IconName.CalendarTimes, FluentUIIcons.CalendarAgenda },
        { IconName.CalendarWeek, FluentUIIcons.CalendarWeekNumbers },
        { IconName.Camera, FluentUIIcons.Camera },
        { IconName.CameraRetro, FluentUIIcons.CameraSparkles },
        { IconName.Car, FluentUIIcons.VehicleCar },
        { IconName.CaretSquareRight, FluentUIIcons.CaretRight },
        { IconName.Cart, FluentUIIcons.ShoppingBag },
        { IconName.CartMinus, FluentUIIcons.ShoppingBagDismiss },
        { IconName.CartPlus, FluentUIIcons.ShoppingBagAdd },
        { IconName.Chair, FluentUIIcons.Couch },
        { IconName.ChartArea, FluentUIIcons.DataArea },
        { IconName.ChartBar, FluentUIIcons.DataBarVertical },
        { IconName.ChartLine, FluentUIIcons.DataLine },
        { IconName.ChartPie, FluentUIIcons.DataPie },
        { IconName.ChartScatter, FluentUIIcons.DataScatter },
        { IconName.Check, FluentUIIcons.Checkmark },
        { IconName.CheckCircle, FluentUIIcons.CheckmarkCircle },
        { IconName.CheckDouble, FluentUIIcons.CheckmarkStarburst },
        { IconName.CheckSquare, FluentUIIcons.CheckmarkSquare },
        { IconName.ChevronLeft, FluentUIIcons.ChevronLeft },
        { IconName.ChevronRight, FluentUIIcons.ChevronRight },
        { IconName.ChevronUp, FluentUIIcons.ChevronUp },
        { IconName.ChevronDown, FluentUIIcons.ChevronDown },
        { IconName.Circle, FluentUIIcons.Circle },
        { IconName.City, FluentUIIcons.City },
        { IconName.Clear, FluentUIIcons.Dismiss },
        { IconName.ClinicMedical, FluentUIIcons.BriefcaseMedical },
        { IconName.Clipboard, FluentUIIcons.Clipboard },
        { IconName.Clock, FluentUIIcons.Clock },
        { IconName.ClosedCaptioning, FluentUIIcons.ClosedCaption },
        { IconName.Cloud, FluentUIIcons.Cloud },
        { IconName.CloudDownloadAlt, FluentUIIcons.CloudArrowDown },
        { IconName.CloudUploadAlt, FluentUIIcons.CloudArrowUp },
        { IconName.Cocktail, FluentUIIcons.DrinkMargarita },
        { IconName.Code, FluentUIIcons.Code },
        { IconName.Coffee, FluentUIIcons.DrinkCoffee },
        { IconName.Comment, FluentUIIcons.Comment },
        { IconName.CommentAlt, FluentUIIcons.CommentArrowLeft },
        { IconName.Comments, FluentUIIcons.CommentMultiple },
        { IconName.CompactDisc, FluentUIIcons.MusicNote1 },
        { IconName.Compass, FluentUIIcons.CompassNorthwest },
        { IconName.Compress, FluentUIIcons.ArrowMinimize },
        { IconName.Copy, FluentUIIcons.Copy },
        { IconName.Copyright, FluentUIIcons.CheckmarkStarburst },
        { IconName.CreditCard, FluentUIIcons.Payment },
        { IconName.Crop, FluentUIIcons.Crop },
        { IconName.Cut, FluentUIIcons.Cut },
        { IconName.Dashboard, FluentUIIcons.LayoutColumnTwoSplitLeft },
        { IconName.Delete, FluentUIIcons.Delete },
        { IconName.Desktop, FluentUIIcons.Desktop },
        { IconName.Dice, FluentUIIcons.CubeQuick },
        { IconName.Directions, FluentUIIcons.Directions },
        { IconName.Dog, FluentUIIcons.AnimalDog },
        { IconName.DollarSign, FluentUIIcons.CurrencyDollarEuro },
        { IconName.DotCircle, FluentUIIcons.Record },
        { IconName.Download, FluentUIIcons.ArrowDownload },
        { IconName.Dumbbell, FluentUIIcons.Dumbbell },
        { IconName.Edit, FluentUIIcons.Edit },
        { IconName.Eject, FluentUIIcons.PlugDisconnected },
        { IconName.Ethernet, FluentUIIcons.Wifi1 },
        { IconName.EuroSign, FluentUIIcons.CurrencyDollarEuro },
        { IconName.Exclamation, FluentUIIcons.ShieldError },
        { IconName.ExclamationCircle, FluentUIIcons.ErrorCircle },
        { IconName.ExclamationTriangle, FluentUIIcons.Warning },
        { IconName.Expand, FluentUIIcons.ArrowMaximize },
        { IconName.ExpandArrowsAlt, FluentUIIcons.FullScreenMaximize },
        { IconName.ExpandLess, FluentUIIcons.ChevronUp },
        { IconName.ExpandMore, FluentUIIcons.ChevronDown },
        { IconName.ExternalLinkSquareAlt, FluentUIIcons.LinkSquare },
        { IconName.Eye, FluentUIIcons.Eye },
        { IconName.EyeSlash, FluentUIIcons.EyeOff },
        { IconName.FastBackward, FluentUIIcons.Rewind },
        { IconName.FastForward, FluentUIIcons.FastForward },
        { IconName.File, FluentUIIcons.Document },
        { IconName.FileAlt, FluentUIIcons.DocumentOnePage },
        { IconName.FileDownload, FluentUIIcons.DocumentArrowDown },
        { IconName.FilePdf, FluentUIIcons.DocumentPdf },
        { IconName.FileUpload, FluentUIIcons.DocumentArrowUp },
        { IconName.Film, FluentUIIcons.Filmstrip },
        { IconName.Filter, FluentUIIcons.Filter },
        { IconName.Fingerprint, FluentUIIcons.Fingerprint },
        { IconName.Fire, FluentUIIcons.Fire },
        { IconName.Flag, FluentUIIcons.Flag },
        { IconName.Flask, FluentUIIcons.Beaker },
        { IconName.Folder, FluentUIIcons.Folder },
        { IconName.FolderOpen, FluentUIIcons.FolderOpen },
        { IconName.FolderPlus, FluentUIIcons.FolderAdd },
        { IconName.Forward, FluentUIIcons.FastForward },
        { IconName.Frown, FluentUIIcons.EmojiSad },
        { IconName.FrownOpen, FluentUIIcons.EmojiSadSlight },
        { IconName.Gamepad, FluentUIIcons.Games },
        { IconName.GasPump, FluentUIIcons.GasPump },
        { IconName.Gavel, FluentUIIcons.Gavel },
        { IconName.Gift, FluentUIIcons.Gift },
        { IconName.Globe, FluentUIIcons.Globe },
        { IconName.Grin, FluentUIIcons.Emoji },
        { IconName.GripLines, FluentUIIcons.SplitHorizontal },
        { IconName.GripVertical, FluentUIIcons.SplitVertical },
        { IconName.HandPaper, FluentUIIcons.HandLeft },
        { IconName.HandsHelping, FluentUIIcons.Handshake },
        { IconName.Headphones, FluentUIIcons.Headphones },
        { IconName.Headset, FluentUIIcons.Headset },
        { IconName.Heart, FluentUIIcons.Heart },
        { IconName.Highlighter, FluentUIIcons.Highlight },
        { IconName.History, FluentUIIcons.History },
        { IconName.Home, FluentUIIcons.Home },
        { IconName.Hospital, FluentUIIcons.BuildingPeople },
        { IconName.Hotel, FluentUIIcons.Building },
        { IconName.HotTub, FluentUIIcons.Showerhead },
        { IconName.Hourglass, FluentUIIcons.Hourglass },
        { IconName.IdCard, FluentUIIcons.ContactCard },
        { IconName.Image, FluentUIIcons.Image },
        { IconName.Images, FluentUIIcons.ImageSearch },
        { IconName.Inbox, FluentUIIcons.MailInbox },
        { IconName.Indent, FluentUIIcons.TextIndentIncrease },
        { IconName.Infinity, FluentUIIcons.NumberSymbol },
        { IconName.Info, FluentUIIcons.Info },
        { IconName.InfoCircle, FluentUIIcons.InfoShield },
        { IconName.Italic, FluentUIIcons.TextItalic },
        { IconName.Key, FluentUIIcons.Key },
        { IconName.Keyboard, FluentUIIcons.Keyboard },
        { IconName.Language, FluentUIIcons.LocalLanguage },
        { IconName.Laptop, FluentUIIcons.Laptop },
        { IconName.LaptopCode, FluentUIIcons.LaptopSettings },
        { IconName.Laugh, FluentUIIcons.EmojiLaugh },
        { IconName.LayerGroup, FluentUIIcons.Layer },
        { IconName.Lightbulb, FluentUIIcons.Lightbulb },
        { IconName.Link, FluentUIIcons.Link },
        { IconName.List, FluentUIIcons.List },
        { IconName.ListOl, FluentUIIcons.TextBulletList },
        { IconName.ListUl, FluentUIIcons.TextNumberListLtr },
        { IconName.LocationArrow, FluentUIIcons.LocationArrow },
        { IconName.Lock, FluentUIIcons.LockClosed },
        { IconName.LockOpen, FluentUIIcons.LockOpen },
        { IconName.Mail, FluentUIIcons.Mail },
        { IconName.MailOpen, FluentUIIcons.MailRead },
        { IconName.Map, FluentUIIcons.Map },
        { IconName.MapMarker, FluentUIIcons.Location },
        { IconName.MapMarkerAlt, FluentUIIcons.MyLocation },
        { IconName.Memory, FluentUIIcons.Storage },
        { IconName.Microphone, FluentUIIcons.SlideMicrophone },
        { IconName.MicrophoneSlash, FluentUIIcons.BookOpenMicrophone },
        { IconName.MinusCircle, FluentUIIcons.SubtractCircle },
        { IconName.MinusSquare, FluentUIIcons.SubtractSquare },
        { IconName.MoneyBillAlt, FluentUIIcons.Money },
        { IconName.Moon, FluentUIIcons.WeatherMoon },
        { IconName.MoreHorizontal, FluentUIIcons.MoreHorizontal },
        { IconName.MoreVertical, FluentUIIcons.MoreVertical },
        { IconName.Motorcycle, FluentUIIcons.VehicleBicycle },
        { IconName.Mouse, FluentUIIcons.CursorClick },
        { IconName.Music, FluentUIIcons.MusicNote2 },
        { IconName.PaintBrush, FluentUIIcons.PaintBrush },
        { IconName.PaintRoller, FluentUIIcons.PaintBucket },
        { IconName.Palette, FluentUIIcons.Color },
        { IconName.Paperclip, FluentUIIcons.Attach },
        { IconName.PaperPlane, FluentUIIcons.Send },
        { IconName.Parking, FluentUIIcons.VehicleCarParking },
        { IconName.Paste, FluentUIIcons.ClipboardPaste },
        { IconName.Pause, FluentUIIcons.Pause },
        { IconName.PauseCircle, FluentUIIcons.PauseCircle },
        { IconName.Pen, FluentUIIcons.Pen },
        { IconName.Phone, FluentUIIcons.Call },
        { IconName.PhoneAlt, FluentUIIcons.Call },
        { IconName.PizzaSlice, FluentUIIcons.FoodPizza },
        { IconName.Plane, FluentUIIcons.Airplane },
        { IconName.PlaneArrival, FluentUIIcons.AirplaneLanding },
        { IconName.PlaneDeparture, FluentUIIcons.AirplaneTakeOff },
        { IconName.Play, FluentUIIcons.Play },
        { IconName.PlayCircle, FluentUIIcons.PlayCircle },
        { IconName.Plug, FluentUIIcons.PlugConnected },
        { IconName.PlusCircle, FluentUIIcons.AddCircle },
        { IconName.PlusSquare, FluentUIIcons.AddSquare },
        { IconName.Poll, FluentUIIcons.Poll },
        { IconName.Portrait, FluentUIIcons.PersonSquare },
        { IconName.Print, FluentUIIcons.Print },
        { IconName.PuzzlePiece, FluentUIIcons.PuzzlePiece },
        { IconName.QuestionCircle, FluentUIIcons.QuestionCircle },
        { IconName.QuoteRight, FluentUIIcons.TextQuote },
        { IconName.Random, FluentUIIcons.NumberCircle0 },
        { IconName.Receipt, FluentUIIcons.Receipt },
        { IconName.Redo, FluentUIIcons.ArrowRedo },
        { IconName.Remove, FluentUIIcons.Delete },
        { IconName.RemoveFormat, FluentUIIcons.ClearFormatting },
        { IconName.Reply, FluentUIIcons.ArrowReply },
        { IconName.ReplyAll, FluentUIIcons.ArrowReplyAll },
        { IconName.Restroom, FluentUIIcons.BreakoutRoom },
        { IconName.Rss, FluentUIIcons.Rss },
        { IconName.RulerHorizontal, FluentUIIcons.Ruler },
        { IconName.Running, FluentUIIcons.Run },
        { IconName.Satellite, FluentUIIcons.Rocket },
        { IconName.Save, FluentUIIcons.Save },
        { IconName.School, FluentUIIcons.LearningApp },
        { IconName.Screenshot, FluentUIIcons.Screenshot },
        { IconName.SdCard, FluentUIIcons.Sim },
        { IconName.Search, FluentUIIcons.Search },
        { IconName.SearchMinus, FluentUIIcons.ZoomOut },
        { IconName.SearchPlus, FluentUIIcons.ZoomIn },
        { IconName.Seedling, FluentUIIcons.PlantGrass },
        { IconName.Send, FluentUIIcons.Send },
        { IconName.Server, FluentUIIcons.Server },
        { IconName.Settings, FluentUIIcons.Settings },
        { IconName.Shapes, FluentUIIcons.Shapes },
        { IconName.Share, FluentUIIcons.Share },
        { IconName.ShareAlt, FluentUIIcons.ShareIos },
        { IconName.Shield, FluentUIIcons.Shield },
        { IconName.ShieldAlt, FluentUIIcons.ShieldTask },
        { IconName.Ship, FluentUIIcons.VehicleShip },
        { IconName.ShoppingBag, FluentUIIcons.ShoppingBag },
        { IconName.ShoppingBasket, FluentUIIcons.ShoppingBag },
        { IconName.ShoppingCart, FluentUIIcons.Cart },
        { IconName.ShuttleVan, FluentUIIcons.VehicleTruck },
        { IconName.SimCard, FluentUIIcons.Sim },
        { IconName.SliderHorizontal, FluentUIIcons.PanelRightContract },
        { IconName.Smartphone, FluentUIIcons.Phone },
        { IconName.Smile, FluentUIIcons.EmojiSmileSlight },
        { IconName.Smoking, FluentUIIcons.Fire },
        { IconName.SmokingBan, FluentUIIcons.Fireplace },
        { IconName.Sms, FluentUIIcons.Comment },
        { IconName.Snowflake, FluentUIIcons.WeatherSnowflake },
        { IconName.Sort, FluentUIIcons.ArrowSort },
        { IconName.SortAlphaDown, FluentUIIcons.TextSortDescending },
        { IconName.SortAlphaUp, FluentUIIcons.TextSortAscending },
        { IconName.SortAmountDownAlt, FluentUIIcons.TextSortAscending },
        { IconName.SortDown, FluentUIIcons.ArrowSortDown },
        { IconName.SortUp, FluentUIIcons.ArrowSortUp },
        { IconName.Spa, FluentUIIcons.WeatherSunnyLow },
        { IconName.SpellCheck, FluentUIIcons.Check },
        { IconName.Square, FluentUIIcons.Square },
        { IconName.Star, FluentUIIcons.Star },
        { IconName.StarHalf, FluentUIIcons.StarHalf },
        { IconName.StepBackward, FluentUIIcons.ArrowStepInLeft },
        { IconName.StepForward, FluentUIIcons.ArrowStepInRight },
        { IconName.StickyNote, FluentUIIcons.Sticker },
        { IconName.Stop, FluentUIIcons.Stop },
        { IconName.Store, FluentUIIcons.BuildingShop },
        { IconName.StoreAlt, FluentUIIcons.StoreMicrosoft },
        { IconName.Stream, FluentUIIcons.Stream },
        { IconName.StreetView, FluentUIIcons.EyeTracking },
        { IconName.Strikethrough, FluentUIIcons.TextStrikethrough },
        { IconName.Subscript, FluentUIIcons.TextSubscript },
        { IconName.Subway, FluentUIIcons.VehicleSubway },
        { IconName.Suitcase, FluentUIIcons.Briefcase },
        { IconName.Sun, FluentUIIcons.WeatherSunny },
        { IconName.Superscript, FluentUIIcons.TextSuperscript },
        { IconName.SwimmingPool, FluentUIIcons.SwimmingPool },
        { IconName.Sync, FluentUIIcons.ArrowSync },
        { IconName.SyncAlt, FluentUIIcons.FolderSync },
        { IconName.Table, FluentUIIcons.Table },
        { IconName.Tablet, FluentUIIcons.Tablet },
        { IconName.Tag, FluentUIIcons.Tag },
        { IconName.Taxi, FluentUIIcons.VehicleCab },
        { IconName.TextHeight, FluentUIIcons.AutoFitHeight },
        { IconName.ThumbsDown, FluentUIIcons.ThumbLike },
        { IconName.ThumbsUp, FluentUIIcons.ThumbDislike },
        { IconName.Ticket, FluentUIIcons.TicketHorizontal },
        { IconName.TicketAlt, FluentUIIcons.TicketDiagonal },
        { IconName.Times, FluentUIIcons.Dismiss },
        { IconName.TimesCircle, FluentUIIcons.DismissCircle },
        { IconName.Tint, FluentUIIcons.Eyedropper },
        { IconName.TintSlash, FluentUIIcons.EyedropperOff },
        { IconName.TrafficLight, FluentUIIcons.RoadCone },
        { IconName.Train, FluentUIIcons.DriveTrain },
        { IconName.Tram, FluentUIIcons.VehicleSubway },
        { IconName.Tree, FluentUIIcons.TreeDeciduous },
        { IconName.Truck, FluentUIIcons.VehicleTruck },
        { IconName.Tv, FluentUIIcons.Tv },
        { IconName.UmbrellaBeach, FluentUIIcons.Umbrella },
        { IconName.Underline, FluentUIIcons.TextUnderline },
        { IconName.Undo, FluentUIIcons.ArrowUndo },
        { IconName.Unlock, FluentUIIcons.LockOpen },
        { IconName.User, FluentUIIcons.Person },
        { IconName.UserCheck, FluentUIIcons.CheckboxPerson },
        { IconName.UserCircle, FluentUIIcons.PersonCircle },
        { IconName.UserFriends, FluentUIIcons.People },
        { IconName.UserPlus, FluentUIIcons.PersonAdd },
        { IconName.Users, FluentUIIcons.People },
        { IconName.UserTie, FluentUIIcons.PersonStarburst },
        { IconName.Utensils, FluentUIIcons.Food },
        { IconName.Video, FluentUIIcons.Video },
        { IconName.VideoSlash, FluentUIIcons.VideoOff },
        { IconName.Voicemail, FluentUIIcons.Voicemail },
        { IconName.VolumeDown, FluentUIIcons.Speaker1 },
        { IconName.VolumeMute, FluentUIIcons.SpeakerMute },
        { IconName.VolumeOff, FluentUIIcons.SpeakerOff },
        { IconName.VolumeUp, FluentUIIcons.Speaker2 },
        { IconName.Walking, FluentUIIcons.PersonWalking },
        { IconName.Wallet, FluentUIIcons.Wallet },
        { IconName.Wheelchair, FluentUIIcons.Accessibility },
        { IconName.Wifi, FluentUIIcons.Wifi1 },
        { IconName.WineBottle, FluentUIIcons.DrinkWine },
        { IconName.Wrench, FluentUIIcons.Wrench },
        { IconName.Zoom, FluentUIIcons.Search },
        { IconName.ZoomIn, FluentUIIcons.ZoomIn },
        { IconName.ZoomOut, FluentUIIcons.ZoomOut },
    };

    private static Dictionary<IconStyle, string> styles = new()
    {
        { IconStyle.Solid, "icon-ic-filled" },
        { IconStyle.Regular, "icon-ic-regular" },
        { IconStyle.Light, "icon-ic-light" },
        { IconStyle.DuoTone, "icon-ic-duo" },
    };

    #endregion

    #region Methods

    public override string IconSize( IconSize iconSize )
    {
        return iconSize switch
        {
            Blazorise.IconSize.ExtraSmall => "icon-ic-xs",
            Blazorise.IconSize.Small => "icon-ic-sm",
            Blazorise.IconSize.Large => "icon-ic-lg",
            Blazorise.IconSize.x2 => "icon-ic-2x",
            Blazorise.IconSize.x3 => "icon-ic-3x",
            Blazorise.IconSize.x4 => "icon-ic-4x",
            Blazorise.IconSize.x5 => "icon-ic-5x",
            Blazorise.IconSize.x6 => "icon-ic-6x",
            Blazorise.IconSize.x7 => "icon-ic-7x",
            Blazorise.IconSize.x8 => "icon-ic-8x",
            Blazorise.IconSize.x9 => "icon-ic-9x",
            Blazorise.IconSize.x10 => "icon-ic-10x",
            _ => null,
        };
    }

    public override string GetIconName( IconName iconName, IconStyle iconStyle )
    {
        if ( names.TryGetValue( iconName, out var name ) )
        {
            if ( iconStyle == IconStyle.Solid )
            {
                return name.Replace( "_regular", "_filled" );
            }

            return name;
        }

        return null;
    }

    public override void SetIconName( IconName name, string newName )
    {
        names[name] = newName;
    }

    public override string GetStyleName( IconStyle iconStyle )
    {
        return null;
    }

    protected override bool ContainsStyleName( string iconName )
    {
        return iconName.Split( ' ' ).Any( x => styles.Values.Contains( x ) || new string[] { "icon-ic-brand" }.Contains( x ) );
    }

    #endregion

    #region Properties

    public override bool IconNameAsContent => false;

    #endregion
}