namespace Translations.Domain;

public static class TranslationCatalog
{
    private static readonly Dictionary<string, Dictionary<string, string>> Translations = new(StringComparer.OrdinalIgnoreCase)
    {
        [LanguageCode.Turkish] = new(StringComparer.OrdinalIgnoreCase)
        {
            // Security
            ["Security.InvalidCredentials"] = "Geçersiz e-posta veya parola.",
            ["Security.EmailAlreadyExists"] = "Bu e-posta adresi zaten kullanımda.",
            ["Security.UserNotFound"] = "Kullanıcı bulunamadı.",
            ["Security.InvalidRefreshToken"] = "Yenileme belirteci geçersiz veya süresi dolmuş.",
            ["Security.SessionRevoked"] = "Oturum sonlandırıldı.",
            ["Security.InvalidEmail"] = "Geçersiz e-posta formatı.",
            ["Security.WeakPassword"] = "Parola güvenlik kriterlerini karşılamıyor.",
            ["Security.AccountLocked"] = "Hesap çok fazla hatalı giriş nedeniyle kilitlendi.",

            // Files
            ["Files.FileNotFound"] = "İstenen dosya bulunamadı.",
            ["Files.FileTooLarge"] = "Dosya boyutu izin verilen sınırı aşıyor.",
            ["Files.InvalidSignature"] = "Dosya içeriği imza (magic byte) doğrulaması başarısız.",
            ["Files.EmptyFile"] = "Yüklenen dosya boş olamaz.",
            ["Files.AccessDenied"] = "Bu dosyaya erişim yetkiniz bulunmamaktadır.",
            ["Files.InvalidContentType"] = "Desteklenmeyen dosya türü.",
            ["Files.UploadFailed"] = "Dosya depolama alanına yüklenemedi.",
            ["Files.UnauthorizedUpload"] = "Bu dosyayı yükleme yetkiniz bulunmamaktadır.",

            // Notifications
            ["Notifications.InvalidEmail"] = "Geçersiz e-posta adresi formatı.",
            ["Notifications.InvalidPhoneNumber"] = "Geçersiz telefon numarası formatı.",
            ["Notifications.InvalidSubject"] = "Bildirim başlığı geçersiz.",
            ["Notifications.InvalidBody"] = "Bildirim gövdesi geçersiz veya boş.",
            ["Notifications.AlreadySent"] = "Bu bildirim zaten gönderilmiş.",
            ["Notifications.AlreadyCancelled"] = "Bu bildirim zaten iptal edilmiş.",
            ["Notifications.NotFound"] = "Bildirim kaydı bulunamadı.",
            ["Notifications.SendFailed"] = "Bildirim gönderimi başarısız oldu.",
            ["Notifications.DeliveryFailed"] = "E-posta teslimatı başarısız oldu.",
            ["Notifications.SmsDeliveryFailed"] = "SMS teslimatı başarısız oldu.",
            ["Notifications.RetryFailed"] = "Bildirim yeniden denemesi başarısız oldu.",

            // Auditing & Messaging
            ["Auditing.NotFound"] = "Denetim günlüğü kaydı bulunamadı.",
            ["Messaging.PublishFailed"] = "Mesaj yayınlanamadı.",
            ["Messaging.MessageNotFound"] = "İşlenecek outbox mesajı bulunamadı.",
            ["Scheduling.JobNotFound"] = "Zamanlanmış iş kaydı bulunamadı.",
            ["Webhooks.SubscriptionNotFound"] = "Webhook aboneliği bulunamadı.",
            ["Webhooks.InvalidUrl"] = "Geçersiz webhook hedef URL adresi.",
            ["Webhooks.DeliveryFailed"] = "Webhook bildirim teslimatı başarısız oldu.",
            ["Webhooks.InvalidSignature"] = "Webhook HMAC-SHA256 imzası geçersiz.",

            // Common / General
            ["Common.ValidationFailed"] = "Bir veya birden fazla doğrulama hatası oluştu.",
            ["Common.NotFound"] = "İstenen kaynak bulunamadı.",
            ["Common.Unauthorized"] = "Bu işlem için kimlik doğrulaması gereklidir.",
            ["Common.Forbidden"] = "Bu işlem için yetkiniz bulunmamaktadır.",
            ["Common.Conflict"] = "İşlem mevcut durumla çakışıyor.",
            ["Common.InternalError"] = "Beklenmeyen bir sunucu hatası meydana geldi."
        },

        [LanguageCode.English] = new(StringComparer.OrdinalIgnoreCase)
        {
            // Security
            ["Security.InvalidCredentials"] = "Invalid email or password.",
            ["Security.EmailAlreadyExists"] = "This email address is already in use.",
            ["Security.UserNotFound"] = "User not found.",
            ["Security.InvalidRefreshToken"] = "Refresh token is invalid or expired.",
            ["Security.SessionRevoked"] = "Session has been revoked.",
            ["Security.InvalidEmail"] = "Invalid email format.",
            ["Security.WeakPassword"] = "Password does not meet complexity requirements.",
            ["Security.AccountLocked"] = "Account has been locked due to too many failed attempts.",

            // Files
            ["Files.FileNotFound"] = "Requested file was not found.",
            ["Files.FileTooLarge"] = "File size exceeds the allowed limit.",
            ["Files.InvalidSignature"] = "File signature (magic byte) verification failed.",
            ["Files.EmptyFile"] = "Uploaded file cannot be empty.",
            ["Files.AccessDenied"] = "You do not have permission to access this file.",
            ["Files.InvalidContentType"] = "Unsupported file type.",
            ["Files.UploadFailed"] = "Failed to upload file to storage.",
            ["Files.UnauthorizedUpload"] = "You do not have permission to upload this file.",

            // Notifications
            ["Notifications.InvalidEmail"] = "Invalid email address format.",
            ["Notifications.InvalidPhoneNumber"] = "Invalid phone number format.",
            ["Notifications.InvalidSubject"] = "Notification subject is invalid.",
            ["Notifications.InvalidBody"] = "Notification body is invalid or empty.",
            ["Notifications.AlreadySent"] = "This notification has already been sent.",
            ["Notifications.AlreadyCancelled"] = "This notification has already been cancelled.",
            ["Notifications.NotFound"] = "Notification record not found.",
            ["Notifications.SendFailed"] = "Notification dispatch failed.",
            ["Notifications.DeliveryFailed"] = "Email delivery failed.",
            ["Notifications.SmsDeliveryFailed"] = "SMS delivery failed.",
            ["Notifications.RetryFailed"] = "Notification retry failed.",

            // Auditing & Messaging
            ["Auditing.NotFound"] = "Audit log entry was not found.",
            ["Messaging.PublishFailed"] = "Failed to publish message.",
            ["Messaging.MessageNotFound"] = "Outbox message not found.",
            ["Scheduling.JobNotFound"] = "Scheduled job was not found.",
            ["Webhooks.SubscriptionNotFound"] = "Webhook subscription was not found.",
            ["Webhooks.InvalidUrl"] = "Invalid webhook target URL.",
            ["Webhooks.DeliveryFailed"] = "Webhook delivery failed.",
            ["Webhooks.InvalidSignature"] = "Invalid webhook HMAC-SHA256 signature.",

            // Common / General
            ["Common.ValidationFailed"] = "One or more validation errors occurred.",
            ["Common.NotFound"] = "The requested resource was not found.",
            ["Common.Unauthorized"] = "Authentication is required for this action.",
            ["Common.Forbidden"] = "You do not have permission to perform this action.",
            ["Common.Conflict"] = "The operation conflicts with current state.",
            ["Common.InternalError"] = "An unexpected server error occurred."
        },

        [LanguageCode.German] = new(StringComparer.OrdinalIgnoreCase)
        {
            // Security
            ["Security.InvalidCredentials"] = "Ungültige E-Mail-Adresse oder Passwort.",
            ["Security.EmailAlreadyExists"] = "Diese E-Mail-Adresse wird bereits verwendet.",
            ["Security.UserNotFound"] = "Benutzer nicht gefunden.",
            ["Security.InvalidRefreshToken"] = "Refresh-Token ist ungültig oder abgelaufen.",
            ["Security.SessionRevoked"] = "Sitzung wurde beendet.",
            ["Security.InvalidEmail"] = "Ungültiges E-Mail-Format.",
            ["Security.WeakPassword"] = "Passwort erfüllt die Sicherheitsanforderungen nicht.",
            ["Security.AccountLocked"] = "Konto wurde aufgrund zu vieler Fehlversuche gesperrt.",

            // Files
            ["Files.FileNotFound"] = "Die angeforderte Datei wurde nicht gefunden.",
            ["Files.FileTooLarge"] = "Dateigröße überschreitet das zulässige Limit.",
            ["Files.InvalidSignature"] = "Dateisignatur-Überprüfung fehlgeschlagen.",
            ["Files.EmptyFile"] = "Die hochgeladene Datei darf nicht leer sein.",
            ["Files.AccessDenied"] = "Sie haben keine Berechtigung für diese Datei.",
            ["Files.InvalidContentType"] = "Nicht unterstützter Dateityp.",
            ["Files.UploadFailed"] = "Datei konnte nicht gespeichert werden.",
            ["Files.UnauthorizedUpload"] = "Sie haben keine Berechtigung, diese Datei hochzuladen.",

            // Notifications
            ["Notifications.InvalidEmail"] = "Ungültiges E-Mail-Adressformat.",
            ["Notifications.InvalidPhoneNumber"] = "Ungültiges Telefonnummernformat.",
            ["Notifications.InvalidSubject"] = "Betreff ist ungültig.",
            ["Notifications.InvalidBody"] = "Nachrichtentext ist ungültig oder leer.",
            ["Notifications.AlreadySent"] = "Diese Benachrichtigung wurde bereits gesendet.",
            ["Notifications.AlreadyCancelled"] = "Diese Benachrichtigung wurde bereits storniert.",
            ["Notifications.NotFound"] = "Benachrichtigung nicht gefunden.",
            ["Notifications.SendFailed"] = "Zustellung der Benachrichtigung fehlgeschlagen.",
            ["Notifications.DeliveryFailed"] = "E-Mail-Zustellung fehlgeschlagen.",
            ["Notifications.SmsDeliveryFailed"] = "SMS-Zustellung fehlgeschlagen.",
            ["Notifications.RetryFailed"] = "Wiederholung der Benachrichtigung fehlgeschlagen.",

            // Auditing & Messaging
            ["Auditing.NotFound"] = "Audit-Protokolleintrag wurde nicht gefunden.",
            ["Messaging.PublishFailed"] = "Nachricht konnte nicht veröffentlicht werden.",
            ["Messaging.MessageNotFound"] = "Outbox-Nachricht nicht gefunden.",
            ["Scheduling.JobNotFound"] = "Geplanter Auftrag wurde nicht gefunden.",
            ["Webhooks.SubscriptionNotFound"] = "Webhook-Abonnement wurde nicht gefunden.",
            ["Webhooks.InvalidUrl"] = "Ungültige Webhook-Ziel-URL.",
            ["Webhooks.DeliveryFailed"] = "Webhook-Zustellung fehlgeschlagen.",
            ["Webhooks.InvalidSignature"] = "Ungültige Webhook HMAC-SHA256 Signatur.",

            // Common / General
            ["Common.ValidationFailed"] = "Ein oder mehrere Validierungsfehler sind aufgetreten.",
            ["Common.NotFound"] = "Die angeforderte Ressource wurde nicht gefunden.",
            ["Common.Unauthorized"] = "Für diese Aktion ist eine Authentifizierung erforderlich.",
            ["Common.Forbidden"] = "Sie haben keine Berechtigung für diese Aktion.",
            ["Common.Conflict"] = "Der Vorgang steht im Konflikt mit dem aktuellen Status.",
            ["Common.InternalError"] = "Ein unerwarteter Serverfehler ist aufgetreten."
        },

        [LanguageCode.Russian] = new(StringComparer.OrdinalIgnoreCase)
        {
            // Security
            ["Security.InvalidCredentials"] = "Неверный адрес электронной почты или пароль.",
            ["Security.EmailAlreadyExists"] = "Этот адрес электронной почты уже используется.",
            ["Security.UserNotFound"] = "Пользователь не найден.",
            ["Security.InvalidRefreshToken"] = "Токен обновления недействителен или истек.",
            ["Security.SessionRevoked"] = "Сессия была отозвана.",
            ["Security.InvalidEmail"] = "Неверный формат адреса электронной почты.",
            ["Security.WeakPassword"] = "Пароль не соответствует требованиям безопасности.",
            ["Security.AccountLocked"] = "Аккаунт заблокирован из-за множества неудачных попыток входа.",

            // Files
            ["Files.FileNotFound"] = "Запрошенный файл не найден.",
            ["Files.FileTooLarge"] = "Размер файла превышает допустимый предел.",
            ["Files.InvalidSignature"] = "Проверка сигнатуры (magic byte) файла не удалась.",
            ["Files.EmptyFile"] = "Загруженный файл не может быть пустым.",
            ["Files.AccessDenied"] = "У вас нет прав на доступ к этому файлу.",
            ["Files.InvalidContentType"] = "Неподдерживаемый тип файла.",
            ["Files.UploadFailed"] = "Не удалось сохранить файл в хранилище.",
            ["Files.UnauthorizedUpload"] = "У вас нет разрешения на загрузку этого файла.",

            // Notifications
            ["Notifications.InvalidEmail"] = "Неверный формат адреса электронной почты.",
            ["Notifications.InvalidPhoneNumber"] = "Неверный формат номера телефона.",
            ["Notifications.InvalidSubject"] = "Тема уведомления недействительна.",
            ["Notifications.InvalidBody"] = "Тело уведомления недействительно или пусто.",
            ["Notifications.AlreadySent"] = "Это уведомление уже отправлено.",
            ["Notifications.AlreadyCancelled"] = "Это уведомление уже отменено.",
            ["Notifications.NotFound"] = "Запись уведомления не найдена.",
            ["Notifications.SendFailed"] = "Отправка уведомления не удалась.",
            ["Notifications.DeliveryFailed"] = "Доставка электронной почты не удалась.",
            ["Notifications.SmsDeliveryFailed"] = "Доставка SMS не удалась.",
            ["Notifications.RetryFailed"] = "Повторная попытка отправки уведомления не удалась.",

            // Auditing & Messaging
            ["Auditing.NotFound"] = "Запись журнала аудита не найдена.",
            ["Messaging.PublishFailed"] = "Не удалось опубликовать сообщение.",
            ["Messaging.MessageNotFound"] = "Сообщение outbox не найдено.",
            ["Scheduling.JobNotFound"] = "Запланированная задача не найдена.",
            ["Webhooks.SubscriptionNotFound"] = "Подписка на вебхук не найдена.",
            ["Webhooks.InvalidUrl"] = "Недействительный целевой URL вебхука.",
            ["Webhooks.DeliveryFailed"] = "Доставка вебхука не удалась.",
            ["Webhooks.InvalidSignature"] = "Недействительная подпись HMAC-SHA256 вебхука.",

            // Common / General
            ["Common.ValidationFailed"] = "Произошла одна или несколько ошибок проверки.",
            ["Common.NotFound"] = "Запрошенный ресурс не найден.",
            ["Common.Unauthorized"] = "Для этого действия требуется аутентификация.",
            ["Common.Forbidden"] = "У вас нет прав на выполнение этого действия.",
            ["Common.Conflict"] = "Операция конфликтует с текущим состоянием.",
            ["Common.InternalError"] = "Произошла непредвиденная ошибка сервера."
        }
    };

    /// <summary>
    /// Translates an error code into the target language.
    /// If translation is missing in the target language, it automatically falls back to Turkish (tr).
    /// If no translation exists at all, returns the code itself.
    /// </summary>
    public static string Translate(string code, string? culture = null)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            return string.Empty;
        }

        var normalizedCulture = LanguageCode.Normalize(culture);

        // 1. Try specified culture
        if (Translations.TryGetValue(normalizedCulture, out var langDict) &&
            langDict.TryGetValue(code, out var translatedText))
        {
            return translatedText;
        }

        // 2. Fallback to Turkish if requested culture wasn't Turkish
        if (!string.Equals(normalizedCulture, LanguageCode.Turkish, StringComparison.OrdinalIgnoreCase) &&
            Translations.TryGetValue(LanguageCode.Turkish, out var trDict) &&
            trDict.TryGetValue(code, out var trFallbackText))
        {
            return trFallbackText;
        }

        // 3. Fallback to original code
        return code;
    }

    public static IReadOnlyDictionary<string, string> GetAll(string? culture = null)
    {
        var normalizedCulture = LanguageCode.Normalize(culture);
        return Translations.TryGetValue(normalizedCulture, out var dict)
            ? dict
            : Translations[LanguageCode.Turkish];
    }
}
