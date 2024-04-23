Welcome, kid. You wanna be part of the family, huh? Well, you know what they say, once you're in, there's no way out. You ready for this?
    -> mainChoice
    
    
== mainChoice ==
    * I'm ready. I'll do whatever it takes.
        That's the spirit. Loyalty and dedication. Alright, here's what you gotta do first. We got a rival gang causing trouble. We need you to send them a message. You up for it?
        -> main1
    * I'm not sure. What exactly am I getting into here?
        You're having second thoughts already? Listen, kid, this ain't a game. You're either in or out. You sure about this?
        -> main2
    * I think I made a mistake. I'm out.
        -> END

== main1 ==
    * Consider it done.
        -> END
    * Uh, can I get some backup for this?
        You want backup, huh? Smart kid. Alright, Tony, go with him. Make sure he doesn't mess this up.
        -> END
    * I don't know if I'm ready for that.
    You're having second thoughts already? Listen, kid, this ain't a game. You're either in or out. You sure about this?
        -> main2
    
== main2 ==
    * I'm sorry, I can't do this.
        Fine. Get outta here. We don't need cowards in our family anyway.
        -> END
    * No, I'm ready. I just needed a moment.
        Alright, good. But remember, hesitation can get you killed out there. You ready now?
        -> main22
    * I'll do it. Let's get this over with.
        -> END
        
== main22 ==
    * Yes, I'm ready.
        Good. Tony, make sure he gets the job done.
        -> END
    * Actually, I think I need more time.
        More time? You either in or out, kid. We don't have time for uncertainty. Yes or No?
        -> YesNo
    *I'm not sure if I can do this.
        You're not sure? Then maybe you're not cut out for this life. Get outta here before you get yourself killed.
        -> END
    
== YesNo ==
    * Yes
        -> END
    * No
        -> END
    