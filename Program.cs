using System;
using System.Threading;

namespace classtextproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! and welcome to.....");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BAD DECISIONS");
            Thread.Sleep(3000);
            Console.WriteLine("Written and Created by Stephen Matthew Storey");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("A text misadventure where your choices will determine the outcome");
            Console.WriteLine("of you and 2 friends on what begins as a promising night of");
            Console.WriteLine("fun and youthfull escipades and potentially turns into..");
            Console.WriteLine("well, something much more.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Before we begin let me state the following, the narrative in this game");
            Console.WriteLine("follows three male characters one of which will be yourself. However, this");
            Console.WriteLine("is in fact a game so we encourage you, the player,");
            Console.WriteLine("to make any choices you like, be creative when it comes to selecting a name, etc.");
            Console.WriteLine("and overall just have fun with it. This game also is not intended for children, if you");
            Console.WriteLine("are under the age of 16 this game is off limits. It includes some mildly explicit language");
            Console.WriteLine("and potentially violent situations, please be aware!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PLEASE ENTER YOUR AGE");
            string age = Console.ReadLine();
            if (Convert.ToInt32(age) >= 16)
            {
                Console.WriteLine("Welcome!");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Sorry, you need to be at least 16 years old to continue.");
                Console.WriteLine("Goodbye!");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }




            Console.WriteLine("PlEASE ENTER YOUR CHARACTER'S NAME");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Well hello there {name}!");
            Console.WriteLine("Let's begin shall we?");
            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine($"It's a perfect Saturday evening and you ({name}) and your two best friends");
            Console.WriteLine("John and Gabe have big plans. The three of you are meeting up for dinner");
            Console.WriteLine("at a Mexican spot conveniently called Three Amigos.");
            Console.WriteLine("Afterwards you guys are headed down to a small university for a big time party");
            Console.WriteLine($"and {name}, you are particularly excited because a girl you have been crushing");
            Console.WriteLine("on attends said university and personally invited you to the bash. Not to mention");
            Console.WriteLine("your favorite college band will be headlining the whole thing! Yes, yes I know,");
            Console.WriteLine("the night could not be more promising.....");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine($"Let me remind you {name} that the three of you are under age but nevertheless");
            Console.WriteLine("you bigshots decide to sit at the bar at this restaurant. Gabe is the smooth talker");
            Console.WriteLine("of the group and persuades the bartender to serve you underage gentlemen a pitcher of");
            Console.WriteLine($"margaritas.....{name}, do you choose to partake in this libation? Or choose something");
            Console.WriteLine("a bit more responsible and non-alcholic?");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TYPE 1 FOR MARGARITAS, TYPE 2 FOR A NON-ALCHOLIC BEVERAGE");
            string drink = Console.ReadLine();

            if (Convert.ToInt32(drink) == 2)
            {
                Console.WriteLine("You're immature loser friends take notice of your unwillingness to participate");
                Console.WriteLine("and sneak out, leaving you stranded and inevitably ending your night here..");
                Console.WriteLine("Turns out they weren't real friends at all but hey the name of the game is");
                Console.WriteLine("BAD DECISIONS not responsible ones. Please try again!");
                Console.WriteLine("GAME OVER");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else

                Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("After some immature conversation and a few rounds for each of you it's time to hit the road.");
            Console.WriteLine($"{name}, you already just dont know when to slow it down and being nervous about meeting up");
            Console.WriteLine("with the girl of your dreams, you find it would be a good idea to bring along a to go cup of your drink.");
            Console.WriteLine("All of you pile into John's car not giving an ounce of thought to the fact drinking and driving");
            Console.WriteLine("is a horrible idea but hey, you guys are young and feeling invincible right about now.");
            Console.WriteLine("Nothing could go wrong right? John drove and knew some back roads to take and with the windows");
            Console.WriteLine("down and the music up life did not get any better on a Saturday Summer night in this town.");
            Console.WriteLine($"{name}, Gabe, and John, the three amigos themselves were on their way!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"IF ONLY YOU ALL KNEW TO WHAT END! {name}, IF ONLY YOU KNEW WHAT TWISTED FATE POTENTIALLY LAY BEFORE YOU ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine($"{name}, you were the first to notice, it looked like flashing lights ahead but it was hard to tell,");
            Console.WriteLine("the lights were reflecting off the tall pine trees and the source was coming from over a hill, everyone in the car suddenly");
            Console.WriteLine("got that sinking feeling in their stomachs.");
            Console.WriteLine("Sure enough it was police lights as the view became clear, the first thought or hope was that someone");
            Console.WriteLine("had just been pulled over. There were at least three sheriff's department vehicles and as John's car moved closer it grew");
            Console.WriteLine("obvious that this was no accident or abnormal traffic stop. This was some type of checkpoint....");
            Console.WriteLine("Most likely being that it was a Saturday night next to a college town this had to be a sobriety checkpoint.");
            Console.WriteLine($"You {name} were always known in your circle of friends as being the most sensible so quickly John and Gabe");
            Console.WriteLine("looked to you for advice, right about then you noticed a small subdivision of houses about twenty yards before");
            Console.WriteLine($"the stop. It was your call {name}, try your luck at the checkpoint or cut a hard left into the subdivision?");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TYPE 1 TO CONTINUE TO THE ROADBLOCK, TYPE 2 TO TAKE A LEFT INTO THE SUBDIVISION");
            string turn = Console.ReadLine();

            if (Convert.ToInt32(turn) == 1)
            {
                Console.Clear();
                Console.WriteLine("You advise John to play it cool, keep straight and ride it out, John is obviously very nervous");
                Console.WriteLine("and as the officer looks over his license and around at the three of you the tension mounts. Seconds");
                Console.WriteLine($"seem like hours,{name} you clinch your fists in agony praying for a miracle. The deputy finally speaks...");
                Console.WriteLine(".....wait for it...");
                Thread.Sleep(15000);
                Console.WriteLine("He ask the three of you to step out of the vehicle, he notices the smell of alcohol and needless to say you guys");
                Console.WriteLine("are busted. Ironically in this case you seemed to have made the honest decision yet it backfired.");
                Console.WriteLine("Please try again!");
                Console.WriteLine("GAME OVER");
                Thread.Sleep(3000);
                Environment.Exit(0);

            }
            else
                Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{name} you yell at John to cut hard left into the subdivision, he does. A little too hard in fact");
            Console.WriteLine("because the tires make a slight screeching sound as the car makes it's turn. John must have let his nerves get");
            Console.WriteLine("the best of him for a moment because it was almost as if he forgot to break at all...Gabe gave him a");
            Console.WriteLine("piercing stare and a 'what the fuck was that man!?' comment. Needless to say this all caused the officers to notice");
            Console.WriteLine("and to the Three Amigos dismay one of the officers began to leave the stop and follow John's car...");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("What to do now? You and the others thought. Surely there is no way out of this as the sheriff dept. SUV");
            Console.WriteLine("followed closer and closer.");
            Console.WriteLine($"Now {name}, you're a smart guy and an idea quickly arose in your thoughts. You laid out the plan for the other two.");
            Console.WriteLine("You told them the only move was to simply pull into a random driveway, to the cop this would hopefully just make it");
            Console.WriteLine("look like this was the planned destination the entire time and we were not evading a traffic sobriety stop");
            Console.WriteLine("and with any luck the officer would continue on and go back to his previous post.");
            Console.WriteLine("Gabe and John agreed as this was the only option available other than stopping in the middle of a neighborhood street");
            Console.WriteLine("and basically admitting guilt. They put the plan into action, John pulled into the next random driveway and all");
            Console.WriteLine("three of them prayed the cop would keep going.....");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            Thread.Sleep(3000);
            Console.WriteLine("He did not keep going...he pulled right in behind the car.");
            Console.WriteLine("The guys were faced with one last choice, one last hope...");
            Console.WriteLine($"Again {name} this was your idea so it was your call, either get out and admit what you're doing to the lawman, or ");
            Console.WriteLine("make a last-ditch effort and tell the officer as you guys are exiting the vehicle that this is a friends house and was");
            Console.WriteLine("your destination all along, again hoping the cop would buy the lie and go on his way.");
            Console.WriteLine("John and Gabe left the decision to you once more...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TYPE 1 TO ADMIT DEFEAT, TYPE 2 TO MAKE ONE LAST BAD DECISION....");
            string last = Console.ReadLine();

            if (Convert.ToInt32(last) == 1)
            {
                Console.Clear();
                Console.WriteLine($"You all confessed to the entire situation, John got a DUI, Gabe and {name} yourself got charged with underage");
                Console.WriteLine("drinking and having an open container as well. You all spent some time in juvenile detention and learned a");
                Console.WriteLine("hard lesson but in the end you all grew from it. As far as he game is concerned...like I've been saying");
                Console.WriteLine("it's not good decisions, it's based on the bad ones!");
                Console.WriteLine("Please try again!");
                Console.WriteLine("GAME OVER");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else

                Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            Console.WriteLine("All three of you stepped out of the vehicle and even though the sheriffs dept. SUV was pulling right in behind John's car,");
            Console.WriteLine("you all played it cool and didn't even glance back as you made your way up to the front door of this random house - ");
            Console.WriteLine("just like you belonged there. That was until you heard the cop yell out 'excuse me youngmen!', you all stopped and");
            Console.WriteLine("turned with hearts pounding. The man in uniform asked what was going on and pointed out that he noticed the");
            Console.WriteLine("swiftness in which our vehicle had pulled in, he said he just wanted to make sure everything was ok and that");
            Console.WriteLine("everyone was safe. Gabe (if you remember from earlier was the smooth talker in the group) confidently stated with suprising");
            Console.WriteLine("ease that everything was quote 'cool' and we were just stopping by our friend Corey's house here to hang out.");
            Console.WriteLine("As astonished as you all were with Gabe's acting abilites the officer was not buying it. He replied by saying he understood");
            Console.WriteLine("but with that being the case surely we would not mind if he walked with you guys to the door, mentioned it was not safe out (for whatever reason)........");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"You all knew you were screwed at that point, this was the end for the Three Amigos. {name}, Gabe, and John all turned");
            Console.WriteLine("back towards the house because shit, why give up now, and approached the front steps.");
            Console.WriteLine("With the cop behind you guys John slowly reached out and pushed the doorbell, not knowing what to expect but knowing it was not going");
            Console.WriteLine("to be good. An older gentlman, maybe in his late 60's answered. With your hopes as low as they could get the man asked");
            Console.WriteLine("'can I help you fellows?', of course Gabe spoke up with a lie and said hey Mr. McDonald, we're here to see Corey.");
            Console.WriteLine("Now you all didn't know what the man was going to say but what came out of his mouth would have shocked M. Night Shyamalan himself.");
            Console.WriteLine("The old bastard actually said 'oh yea! of course, come on in guys! Corey is just downstairs'...you all looked at each other but");
            Console.WriteLine("at the same time tried to keep your cool knowing the law was watching and standing just at the bottom of the steps.");
            Console.WriteLine("The officer quickly apologized for the trouble and gave a goodnight to all parties involved and walked back to his patrol vehicle.");
            Console.WriteLine("You three went inside confused but so relieved and feeling like you had escaped the clutches of death itself, like you had won the lottery!");
            Console.WriteLine("The older man shut the front door and must have had his own situation like this happen to him because he went on to say 'you boys");
            Console.WriteLine("sure dodged a bullet with that one', he then told them how lucky they were they came to HIS door. He told them he had a sixth senxe about these");
            Console.WriteLine("things and could tell by the looks on all your faces the trouble you were in. He then went to the fridge while having you guys wait and make");
            Console.WriteLine("yourselves at home in the living room. He grabbed a few beers for each of you. You guys drank them down happily and continued to laugh and");
            Console.WriteLine("thank the old man. It was no longer than maybe a minute or two before all of you began to feel dizzy and very very tired....");
            Console.WriteLine("As the light faded from your eyes, you heard the old man let out the creepiest laugh you had ever heard, then silence.");



            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"WHAT HAPPENS AFTER THAT IS BLURRY AND HARD TO SAY, YOU HAD AWOKEN IN HAZE SOMETIME LATER. SCREAMS, {name} YOU HEARD LOUD GUTWRENCHING SCREAMS, YOUR VISION WAS BLURRED.");
            Console.WriteLine("IT WAS IN THAT MOMENT YOU REALIZED THE IRONY IN THE BAD DECISIONS YOU HAD MADE. BEFORE THE END, AS THE DARKNESS WAS CLOSING IN, AN ALMOST FUNNY THOUGHT OCCURED IN YOUR THROBBING HEAD");
            Console.WriteLine("OR WHAT WAS LEFT OF IT....SOMETIMES WE PUT OURSELVES IN SITUATIONS WHERE THE ONLY DECISIONS WE HAVE ARE SEEMINGLY BAD ONES, AND IF IN THAT POSITION IT'S");
            Console.WriteLine("SIMPLY A MATTER OF NOT MAKING ONE BAD DECISION TURN INTO MORE BAD DECISIONS, THE LIGHT AND SOUND FADED OUT AS YOU TOOK YOUR LAST BREATH...");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{name}, Gabe, and John we're never heard from again, the roadblock they mistook as a sobriety stop was actually setup");
            Console.WriteLine("to look for some people that had gone missing over the last several months. It's safe to say our Three Amigos found the culprit.");
            Console.WriteLine("You three had, in the most round about and unfortunate way possible, stumbled right into the web of a torturing, cannabalistic murdering psychopath.");
            Console.WriteLine("So did you win? I think the answer to that is obvious. All of the other choices would have led you to trouble but that trouble would");
            Console.WriteLine("have been a far better outcome than what you three recieved.... but hey, you did make it to the end so congratulations!....I guess...hahahahaha");
            Console.WriteLine("THANKS FOR PLAYING!");
            Console.WriteLine("be sure and keep a look out for more text adventures from Stephen Matthew Storey");
        }
    }
}
