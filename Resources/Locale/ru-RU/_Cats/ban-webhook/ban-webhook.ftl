server-ban-string-infinity = **Навсегда**

server-ban-no-name = **Не найден.** ({ $hwid })
server-time-ban =
    **Временный бан на { $mins } { $mins ->**
        [one] **минуту**
        [few] **минуты**
       *[other] **минут**
    **}.**

server-perma-ban = **Постоянный бан**
server-role-ban =
    **Временный бан профессии на { $mins } { $mins ->**
        [one] **минуту**
        [few] **минуты**
       *[other] **минут**
    **}.**

server-perma-role-ban = **Постоянный бан профессии**
server-time-ban-string =
    > **Нарушитель**
    > **Логин:** ``{ $targetName }``
    > **Discord:** { $targetLink }
    
    > **Администратор**
    > **Логин:** ``{ $adminName }``
    > **Discord:** { $adminLink }
    
    > **Время**
    > **Назначено:** { $TimeNow }
    > **Истекает:** { $expiresString }
    
    > **Причина:** { $reason }
    
    > **Уровень тяжести:** { $severity }

server-ban-footer = { $server } | **Раунд:** #{ $round }

server-perma-ban-string =
    > **Нарушитель**
    > **Логин:** ``{ $targetName }``
    > **Discord:** { $targetLink }
    
    > **Администратор**
    > **Логин:** ``{ $adminName }``
    > **Discord:** { $adminLink }
    
    > **Время**
    > **Назначено:** { $TimeNow }
    
    > **Причина:** { $reason }
    
    > **Уровень тяжести:** { $severity }

server-role-ban-string =
    > **Нарушитель**
    > **Логин:** ``{ $targetName }``
    > **Discord:** { $targetLink }
    
    > **Администратор**
    > **Логин:** ``{ $adminName }``
    > **Discord:** { $adminLink }
    
    > **Время**
    > **Назначено:** { $TimeNow }
    > **Истекает:** { $expiresString }
    
    > **Профессии:** { $roles }
    
    > **Причина:** { $reason }
    
    > **Уровень тяжести:** { $severity }

server-perma-role-ban-string =
    > **Нарушитель**
    > **Логин:** ``{ $targetName }``
    > **Discord:** ``{ $targetLink }``
    
    > **Администратор**
    > **Логин:** ``{ $adminName }``
    > **Discord:** { $adminLink }
    
    > **Время**
    > **Назначено:** { $TimeNow }
    
    > **Профессии:** { $roles }
    
    > **Причина:** { $reason }
    
    > **Уровень тяжести:** { $severity }