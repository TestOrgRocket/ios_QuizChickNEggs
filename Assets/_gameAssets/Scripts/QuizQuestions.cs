using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static QuizClasses;

public class QuizQuestions : MonoBehaviour
{
    public QuizData chickenEggQuiz = new QuizData
    {
        Questions = new Question[]
        {
            // 1-10: Basic facts
            new Question{ QuestionText = "What came first: the chicken or the egg?", Options = new[] { "Chicken", "Egg", "Both appeared at the same time", "Science doesn't have a definitive answer" }, Answer = "Science doesn't have a definitive answer" },
            new Question{ QuestionText = "On average, how many eggs does a hen lay per year?", Options = new[] { "50-100", "100-200", "200-300", "300-400" }, Answer = "200-300" },
            new Question{ QuestionText = "What colors can chicken eggs be?", Options = new[] { "Only white", "Only brown", "White and brown", "White, brown, blue, and green" }, Answer = "White, brown, blue, and green" },
            new Question{ QuestionText = "How long does it take a hen to produce one egg?", Options = new[] { "Less than an hour", "About 24-26 hours", "Several days", "Depends on the breed" }, Answer = "About 24-26 hours" },
            new Question{ QuestionText = "What is the study of birds called?", Options = new[] { "Ornithology", "Entomology", "Herpetology", "Ichthyology" }, Answer = "Ornithology" },
            new Question{ QuestionText = "What protein makes up most of an egg white?", Options = new[] { "Albumin", "Keratin", "Collagen", "Casein" }, Answer = "Albumin" },
            new Question{ QuestionText = "How long does it take for a chicken egg to hatch?", Options = new[] { "14 days", "21 days", "28 days", "35 days" }, Answer = "21 days" },
            new Question{ QuestionText = "What is a female chicken called?", Options = new[] { "Rooster", "Hen", "Pullet", "Chick" }, Answer = "Hen" },
            new Question{ QuestionText = "What is a male chicken called?", Options = new[] { "Rooster", "Hen", "Capon", "Cockerel" }, Answer = "Rooster" },
            new Question{ QuestionText = "What is a baby chicken called?", Options = new[] { "Chick", "Pullet", "Cockerel", "Fledgling" }, Answer = "Chick" },

            // 11-20: Biology & behavior
            new Question{ QuestionText = "Can chickens fly?", Options = new[] { "Yes, very well", "Only short distances", "No, not at all", "Only downhill" }, Answer = "Only short distances" },
            new Question{ QuestionText = "What is the red fleshy skin on a chicken's head called?", Options = new[] { "Wattle", "Comb", "Caruncle", "Dewlap" }, Answer = "Comb" },
            new Question{ QuestionText = "How many toes do most chickens have?", Options = new[] { "3", "4", "5", "6" }, Answer = "4" },
            new Question{ QuestionText = "What is the purpose of a chicken's gizzard?", Options = new[] { "To store food", "To grind food", "To produce eggs", "To aid in breathing" }, Answer = "To grind food" },
            new Question{ QuestionText = "At what age do hens typically start laying eggs?", Options = new[] { "4-6 weeks", "12-16 weeks", "18-24 weeks", "1 year" }, Answer = "18-24 weeks" },
            new Question{ QuestionText = "What determines the color of a chicken's earlobes?", Options = new[] { "Age", "Breed", "Diet", "Egg color" }, Answer = "Breed" },
            new Question{ QuestionText = "How many eggs can a hen lay in her lifetime?", Options = new[] { "100-200", "300-500", "600-800", "1000+" }, Answer = "600-800" },
            new Question{ QuestionText = "What is 'brooding' in chickens?", Options = new[] { "A mating dance", "A type of feather", "Sitting on eggs to hatch them", "A digestive process" }, Answer = "Sitting on eggs to hatch them" },
            new Question{ QuestionText = "What is the average body temperature of a chicken?", Options = new[] { "98.6°F (37°C)", "101.5°F (38.6°C)", "105°F (40.5°C)", "107°F (41.7°C)" }, Answer = "105°F (40.5°C)" },
            new Question{ QuestionText = "How long do chickens typically live?", Options = new[] { "2-3 years", "5-10 years", "12-15 years", "20+ years" }, Answer = "5-10 years" },

            // 21-30: Egg facts
            new Question{ QuestionText = "What is the yellow part of an egg called?", Options = new[] { "Albumen", "Yolk", "Chalaza", "Germinal disc" }, Answer = "Yolk" },
            new Question{ QuestionText = "What are the stringy white parts in an egg called?", Options = new[] { "Membranes", "Chalazae", "Albumen strands", "Protein cords" }, Answer = "Chalazae" },
            new Question{ QuestionText = "Why are some egg yolks darker than others?", Options = new[] { "Age of the hen", "Breed of chicken", "The hen's diet", "All of the above" }, Answer = "The hen's diet" },
            new Question{ QuestionText = "How can you tell if an egg is fresh?", Options = new[] { "By its color", "By shaking it", "By the float test", "By its smell" }, Answer = "By the float test" },
            new Question{ QuestionText = "What is the bloom or cuticle on an egg?", Options = new[] { "A protective coating", "A type of bacteria", "An air pocket", "A membrane" }, Answer = "A protective coating" },
            new Question{ QuestionText = "What percentage of an egg's weight is shell?", Options = new[] { "5%", "9-12%", "15-18%", "20%" }, Answer = "9-12%" },
            new Question{ QuestionText = "Which country consumes the most eggs per capita?", Options = new[] { "USA", "China", "Japan", "Mexico" }, Answer = "Japan" },
            new Question{ QuestionText = "What causes green rings around hard-boiled egg yolks?", Options = new[] { "Bacteria", "Overcooking", "Old eggs", "Copper pans" }, Answer = "Overcooking" },
            new Question{ QuestionText = "How many calories are in one large chicken egg?", Options = new[] { "50", "70", "100", "120" }, Answer = "70" },
            new Question{ QuestionText = "What vitamin is NOT found in eggs?", Options = new[] { "Vitamin A", "Vitamin B12", "Vitamin C", "Vitamin D" }, Answer = "Vitamin C" },

            // 31-40: Chicken breeds
            new Question{ QuestionText = "Which chicken breed lays blue eggs?", Options = new[] { "Leghorn", "Rhode Island Red", "Araucana", "Plymouth Rock" }, Answer = "Araucana" },
            new Question{ QuestionText = "What is the most common commercial egg-laying breed?", Options = new[] { "Orpington", "Leghorn", "Sussex", "Wyandotte" }, Answer = "Leghorn" },
            new Question{ QuestionText = "Which breed is known for being exceptionally large?", Options = new[] { "Bantam", "Jersey Giant", "Silkie", "Polish" }, Answer = "Jersey Giant" },
            new Question{ QuestionText = "What breed has fluffy feathers that look like hair?", Options = new[] { "Silkie", "Frizzle", "Polish", "Cochin" }, Answer = "Silkie" },
            new Question{ QuestionText = "Which breed is named after an American state?", Options = new[] { "Rhode Island Red", "New Hampshire", "Delaware", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What is a bantam chicken?", Options = new[] { "A young chicken", "A miniature breed", "A male chicken", "A hybrid breed" }, Answer = "A miniature breed" },
            new Question{ QuestionText = "Which breed is known for its 'muff' and 'beard'?", Options = new[] { "Polish", "Ameraucana", "Houdan", "Sultan" }, Answer = "Ameraucana" },
            new Question{ QuestionText = "What color eggs do Marans chickens lay?", Options = new[] { "White", "Brown", "Dark chocolate brown", "Blue" }, Answer = "Dark chocolate brown" },
            new Question{ QuestionText = "Which breed has feathers that curl outward?", Options = new[] { "Frizzle", "Silkie", "Polish", "Crested" }, Answer = "Frizzle" },
            new Question{ QuestionText = "What is the national bird of France?", Options = new[] { "Eagle", "Rooster", "Swan", "Peacock" }, Answer = "Rooster" },

            // 41-50: Fun facts & records
            new Question{ QuestionText = "What is the world record for most egg yolks in one egg?", Options = new[] { "2", "5", "9", "12" }, Answer = "9" },
            new Question{ QuestionText = "How many eggs are used to make a large omelette in the world record?", Options = new[] { "500", "2,000", "5,000", "15,000" }, Answer = "15,000" },
            new Question{ QuestionText = "What is the term for fear of chickens?", Options = new[] { "Alektorophobia", "Ornithophobia", "Poultryphobia", "Gallinaphobia" }, Answer = "Alektorophobia" },
            new Question{ QuestionText = "How fast can a chicken run?", Options = new[] { "5 mph (8 km/h)", "9 mph (14 km/h)", "14 mph (23 km/h)", "20 mph (32 km/h)" }, Answer = "9 mph (14 km/h)" },
            new Question{ QuestionText = "What percentage of the world's chickens are in China?", Options = new[] { "10%", "25%", "33%", "50%" }, Answer = "33%" },
            new Question{ QuestionText = "How many chickens are there for every human on Earth?", Options = new[] { "About 1", "About 3", "About 5", "About 10" }, Answer = "About 3" },
            new Question{ QuestionText = "What ancient civilization first domesticated chickens?", Options = new[] { "Egyptians", "Chinese", "Indus Valley", "Romans" }, Answer = "Indus Valley" },
            new Question{ QuestionText = "What is 'pecking order'?", Options = new[] { "A feeding schedule", "The hierarchy in a flock", "A type of chicken feed", "A mating ritual" }, Answer = "The hierarchy in a flock" },
            new Question{ QuestionText = "What unusual ability do chickens have regarding color?", Options = new[] { "Night vision", "UV light detection", "Color-changing feathers", "They're colorblind" }, Answer = "UV light detection" },
            new Question{ QuestionText = "What famous fast food chain uses 'The chicken or the egg?' in its ads?", Options = new[] { "KFC", "Chick-fil-A", "Popeyes", "Church's Chicken" }, Answer = "Chick-fil-A" },
            new Question{ QuestionText = "What is the purpose of a chicken's wattles?", Options = new[] { "Hearing", "Temperature regulation", "Egg production", "Mating displays" }, Answer = "Temperature regulation" },

            new Question{ QuestionText = "How many chambers does a chicken's heart have?", Options = new[] { "2", "3", "4", "5" }, Answer = "4" },
            new Question{ QuestionText = "What is the hard plate in a chicken's mouth called?", Options = new[] { "Beak", "Gizzard", "Crop", "Tomia" }, Answer = "Tomia" },
            new Question{ QuestionText = "Where does food go immediately after a chicken swallows it?", Options = new[] { "Gizzard", "Crop", "Intestines", "Cloaca" }, Answer = "Crop" },
            new Question{ QuestionText = "What is the chicken's tail called?", Options = new[] { "Plume", "Flag", "Main", "Sickle" }, Answer = "Sickle" },
            new Question{ QuestionText = "How many eyelids does a chicken have?", Options = new[] { "1", "2", "3", "4" }, Answer = "3" },
            new Question{ QuestionText = "What is the chicken's equivalent of lips?", Options = new[] { "Beak", "Cere", "Tomia", "They don't have any" }, Answer = "They don't have any" },
            new Question{ QuestionText = "What part of a chicken is the 'hock'?", Options = new[] { "Neck", "Leg joint", "Wing tip", "Comb" }, Answer = "Leg joint" },
            new Question{ QuestionText = "What is the 'vent' in a chicken?", Options = new[] { "Nostril", "Multi-purpose opening", "Ear", "Special feather" }, Answer = "Multi-purpose opening" },
            new Question{ QuestionText = "What is the 'saddle' on a rooster?", Options = new[] { "Back feathers", "Neck feathers", "A type of comb", "Foot spur" }, Answer = "Back feathers" },

            // 61-70: Egg science
            new Question{ QuestionText = "What gives eggshells their strength?", Options = new[] { "Keratin", "Calcium carbonate", "Collagen", "Silica" }, Answer = "Calcium carbonate" },
            new Question{ QuestionText = "How many pores does an average eggshell have?", Options = new[] { "About 100", "About 1,000", "About 7,000", "About 17,000" }, Answer = "About 7,000" },
            new Question{ QuestionText = "What is the air cell in an egg?", Options = new[] { "The yolk", "A pocket of air that forms as the egg cools", "A fertilization spot", "Part of the shell" }, Answer = "A pocket of air that forms as the egg cools" },
            new Question{ QuestionText = "Why are some eggs speckled?", Options = new[] { "Calcium deposits", "Pigment variations", "Both of these", "It's random" }, Answer = "Both of these" },
            new Question{ QuestionText = "What determines an egg's shape?", Options = new[] { "The hen's age", "The hen's diet", "The oviduct shape", "The nesting box" }, Answer = "The oviduct shape" },
            new Question{ QuestionText = "How long can fresh eggs be stored at room temperature?", Options = new[] { "1 day", "1 week", "2 weeks", "They shouldn't be stored at room temperature" }, Answer = "1 week" },
            new Question{ QuestionText = "What causes blood spots in eggs?", Options = new[] { "Fertilization", "Ruptured blood vessels", "Disease", "Old age" }, Answer = "Ruptured blood vessels" },
            new Question{ QuestionText = "What is the germinal disc?", Options = new[] { "Part of the shell", "The white spot on the yolk", "The chalazae", "The air cell" }, Answer = "The white spot on the yolk" },
            new Question{ QuestionText = "Why do hard-boiled eggs sometimes have flat ends?", Options = new[] { "Old eggs", "Too much boiling", "Air cell expansion", "Poor hen nutrition" }, Answer = "Air cell expansion" },
            new Question{ QuestionText = "What is the protein that prevents bacteria from entering eggs?", Options = new[] { "Ovalbumin", "Lysozyme", "Avidin", "Keratin" }, Answer = "Lysozyme" },

            // 71-80: Chicken behavior
            new Question{ QuestionText = "Why do chickens take dust baths?", Options = new[] { "To cool off", "To clean their feathers", "To socialize", "To avoid predators" }, Answer = "To clean their feathers" },
            new Question{ QuestionText = "What does it mean when a chicken 'tidbits'?", Options = new[] { "Mating behavior", "Finding food for chicks", "Establishing dominance", "Nesting behavior" }, Answer = "Finding food for chicks" },
            new Question{ QuestionText = "How do chickens communicate danger?", Options = new[] { "Specific clucks", "Wing flapping", "Foot stomping", "All of these" }, Answer = "Specific clucks" },
            new Question{ QuestionText = "Why do roosters crow at dawn?", Options = new[] { "To wake the flock", "To mark territory", "Internal biological clock", "All of these" }, Answer = "All of these" },
            new Question{ QuestionText = "What is 'egg singing'?", Options = new[] { "A mating call", "The noise chicks make before hatching", "A hen's song after laying an egg", "A distress call" }, Answer = "A hen's song after laying an egg" },
            new Question{ QuestionText = "Why do chickens scratch the ground?", Options = new[] { "To find food", "To create dust baths", "To mark territory", "All of these" }, Answer = "All of these" },
            new Question{ QuestionText = "What does a broody hen do?", Options = new[] { "Lays more eggs", "Protects her eggs", "Eats more food", "Becomes aggressive" }, Answer = "Protects her eggs" },
            new Question{ QuestionText = "How do chickens show submission?", Options = new[] { "Crouching", "Running away", "Flying up", "Loud squawking" }, Answer = "Crouching" },
            new Question{ QuestionText = "What is 'vent pecking'?", Options = new[] { "Mating behavior", "Aggressive behavior", "Feeding behavior", "Grooming behavior" }, Answer = "Aggressive behavior" },
            new Question{ QuestionText = "Why do chickens sunbathe?", Options = new[] { "To warm up", "To synthesize vitamin D", "To relax", "All of these" }, Answer = "All of these" },

            // 81-90: Chicken history
            new Question{ QuestionText = "Where were chickens first domesticated?", Options = new[] { "Egypt", "China", "India", "South America" }, Answer = "India" },
            new Question{ QuestionText = "What ancient culture considered chickens sacred?", Options = new[] { "Romans", "Greeks", "Celts", "All of these" }, Answer = "All of these" },
            new Question{ QuestionText = "When did chickens reach Europe?", Options = new[] { "2000 BC", "800 BC", "200 AD", "1000 AD" }, Answer = "800 BC" },
            new Question{ QuestionText = "What was the original purpose of cockfighting?", Options = new[] { "Entertainment", "Religious rituals", "Food source", "Population control" }, Answer = "Religious rituals" },
            new Question{ QuestionText = "Which civilization first developed artificial incubation?", Options = new[] { "Chinese", "Egyptian", "Roman", "Greek" }, Answer = "Egyptian" },
            new Question{ QuestionText = "When were chickens first brought to America?", Options = new[] { "1000 AD by Vikings", "1493 by Columbus", "1607 by Jamestown settlers", "1700s by slaves" }, Answer = "1493 by Columbus" },
            new Question{ QuestionText = "What was the first chicken breed recognized in America?", Options = new[] { "Plymouth Rock", "Rhode Island Red", "Dominique", "Jersey Giant" }, Answer = "Dominique" },
            new Question{ QuestionText = "When was the first poultry show held?", Options = new[] { "1793", "1845", "1895", "1921" }, Answer = "1845" },
            new Question{ QuestionText = "What war led to the development of modern poultry industry?", Options = new[] { "Civil War", "WWI", "WWII", "Vietnam War" }, Answer = "WWII" },
            new Question{ QuestionText = "When were chickens first genetically sequenced?", Options = new[] { "1994", "2004", "2014", "2020" }, Answer = "2004" },

            // 91-100: Fun facts
            new Question{ QuestionText = "What is a group of chickens called?", Options = new[] { "Herd", "Flock", "Peep", "Both flock and peep" }, Answer = "Both flock and peep" },
            new Question{ QuestionText = "How many muscles control a chicken's ear?", Options = new[] { "0", "4", "10", "15" }, Answer = "0" },
            new Question{ QuestionText = "What unusual place can chickens live?", Options = new[] { "Deserts", "Arctic", "High mountains", "All of these" }, Answer = "All of these" },
            new Question{ QuestionText = "What color are a chicken's eggs when they first form?", Options = new[] { "White", "The final color", "Pink", "Clear" }, Answer = "White" },
            new Question{ QuestionText = "How many eggs can a record-holding hen lay in one day?", Options = new[] { "1", "2", "3", "7" }, Answer = "7" },
            new Question{ QuestionText = "What percentage of chicken DNA matches human DNA?", Options = new[] { "20%", "40%", "60%", "80%" }, Answer = "60%" },
            new Question{ QuestionText = "What unusual item can chickens eat?", Options = new[] { "Small rocks", "Glass", "Metal", "All of these" }, Answer = "Small rocks" },
            new Question{ QuestionText = "How fast can a chicken's heart beat?", Options = new[] { "100 bpm", "200 bpm", "300 bpm", "400 bpm" }, Answer = "300 bpm" },
            new Question{ QuestionText = "What musical instrument mimics a chicken?", Options = new[] { "Violin", "Flute", "Clarinet", "Piano" }, Answer = "Clarinet" },
            new Question{ QuestionText = "What's the world record for most eggs balanced on one?", Options = new[] { "5", "10", "20", "29" }, Answer = "29" },
            // 101-110: Egg Cooking Science
            new Question{ QuestionText = "Why do eggs turn white when cooked?", Options = new[] { "Protein denaturation", "Chemical bleaching", "Pigment release", "Water evaporation" }, Answer = "Protein denaturation" },
            new Question{ QuestionText = "What makes hard-boiled eggs easier to peel?", Options = new[] { "Fresh eggs", "Older eggs", "Adding vinegar", "Using cold water" }, Answer = "Older eggs" },
            new Question{ QuestionText = "What causes scrambled eggs to become rubbery?", Options = new[] { "Overcooking", "Undercooking", "Too much milk", "Not enough salt" }, Answer = "Overcooking" },
            new Question{ QuestionText = "Why do chefs recommend room temperature eggs for baking?", Options = new[] { "Better flavor", "Easier mixing", "More volume when whipped", "All of the above" }, Answer = "More volume when whipped" },
            new Question{ QuestionText = "What's the purpose of adding acid (lemon/vinegar) to poached eggs?", Options = new[] { "Flavor", "Faster cooking", "Tighter whites", "Color change" }, Answer = "Tighter whites" },
            new Question{ QuestionText = "Why do some recipes call for egg wash?", Options = new[] { "Flavor", "Browning", "Moisture", "All of the above" }, Answer = "Browning" },
            new Question{ QuestionText = "What creates the green ring around overcooked hard-boiled yolks?", Options = new[] { "Iron sulfide", "Copper oxide", "Chlorophyll", "Carbon buildup" }, Answer = "Iron sulfide" },
            new Question{ QuestionText = "Why should you avoid aluminum pans when cooking eggs?", Options = new[] { "Toxic reaction", "Discoloration", "Sticking", "All of the above" }, Answer = "Discoloration" },
            new Question{ QuestionText = "What's the ideal temperature for cooking custard?", Options = new[] { "140°F (60°C)", "160°F (71°C)", "180°F (82°C)", "200°F (93°C)" }, Answer = "180°F (82°C)" },
            new Question{ QuestionText = "Why do meringues weep?", Options = new[] { "Undercooking", "Humidity", "Sugar content", "All of the above" }, Answer = "All of the above" },

            // 111-120: Chicken Genetics
            new Question{ QuestionText = "What determines egg shell color in chickens?", Options = new[] { "Diet", "Age", "Genetics", "Environment" }, Answer = "Genetics" },
            new Question{ QuestionText = "How many chromosomes do chickens have?", Options = new[] { "39", "78", "156", "It varies" }, Answer = "78" },
            new Question{ QuestionText = "What gene causes the Silkie's fluffy feathers?", Options = new[] { "F gene", "H gene", "Sv gene", "None known" }, Answer = "H gene" },
            new Question{ QuestionText = "What makes Araucana chickens lay blue eggs?", Options = new[] { "Biliverdin", "Oocyanin", "Hemoglobin", "Melanin" }, Answer = "Oocyanin" },
            new Question{ QuestionText = "What is a 'blue' chicken in genetics?", Options = new[] { "Pure breed", "Hybrid", "Diluted black", "Albino variant" }, Answer = "Diluted black" },
            new Question{ QuestionText = "What causes feather-legged chickens?", Options = new[] { "Ptilopody gene", "Extra keratin", "Vitamin deficiency", "Selective breeding" }, Answer = "Ptilopody gene" },
            new Question{ QuestionText = "What determines comb type in chickens?", Options = new[] { "Single gene", "Multiple genes", "Environment", "Random mutation" }, Answer = "Multiple genes" },
            new Question{ QuestionText = "What is 'auto-sexing' in chickens?", Options = new[] { "Self-fertilization", "Gender visible at hatch", "Asexual reproduction", "Genetic modification" }, Answer = "Gender visible at hatch" },
            new Question{ QuestionText = "What gene causes frizzle feathers?", Options = new[] { "F gene", "K gene", "M gene", "P gene" }, Answer = "F gene" },
            new Question{ QuestionText = "What makes black bones in Silkie chickens?", Options = new[] { "Melanin", "Extra calcium", "Genetic mutation", "All of the above" }, Answer = "Melanin" },

            // 121-130: World Records
            new Question{ QuestionText = "What's the record for most eggs laid by one chicken in a day?", Options = new[] { "2", "7", "12", "15" }, Answer = "7" },
            new Question{ QuestionText = "What's the world record for egg throwing distance?", Options = new[] { "98.51m (323ft 2in)", "105.32m (345ft 6in)", "112.44m (368ft 11in)", "120.67m (395ft 11in)" }, Answer = "98.51m (323ft 2in)" },
            new Question{ QuestionText = "What's the record for most eggs balanced on one egg?", Options = new[] { "15", "20", "29", "35" }, Answer = "29" },
            new Question{ QuestionText = "What's the record for most eggs carried in one hand?", Options = new[] { "10", "15", "20", "25" }, Answer = "20" },
            new Question{ QuestionText = "What's the heaviest chicken egg ever recorded?", Options = new[] { "340g (12oz)", "454g (1lb)", "567g (1.25lb)", "680g (1.5lb)" }, Answer = "454g (1lb)" },
            new Question{ QuestionText = "What's the record for most yolks in one egg?", Options = new[] { "5", "7", "9", "11" }, Answer = "9" },
            new Question{ QuestionText = "What's the record for most eggs eaten in one minute?", Options = new[] { "10", "15", "20", "25" }, Answer = "15" },
            new Question{ QuestionText = "What's the largest chicken omelette ever made?", Options = new[] { "5,000 eggs", "10,000 eggs", "15,000 eggs", "20,000 eggs" }, Answer = "15,000 eggs" },
            new Question{ QuestionText = "What's the record for most eggs cracked in one minute?", Options = new[] { "25", "37", "48", "52" }, Answer = "48" },
            new Question{ QuestionText = "What's the record for most eggs carried in a spoon race?", Options = new[] { "1km", "5km", "10km", "42km (marathon)" }, Answer = "42km (marathon)" },

            // 131-140: Chicken Health
            new Question{ QuestionText = "What's a common sign of a healthy chicken?", Options = new[] { "Bright eyes", "Smooth feathers", "Active behavior", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What vitamin deficiency causes curled toe paralysis?", Options = new[] { "A", "B", "D", "E" }, Answer = "B" },
            new Question{ QuestionText = "What causes 'egg binding'?", Options = new[] { "Oversized egg", "Calcium deficiency", "Stress", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What's 'pasty butt' in chicks?", Options = new[] { "Dried droppings blocking vent", "Genetic defect", "Bacterial infection", "Viral disease" }, Answer = "Dried droppings blocking vent" },
            new Question{ QuestionText = "What parasite causes 'gaposis'?", Options = new[] { "Mites", "Lice", "Worms", "Fleas" }, Answer = "Lice" },
            new Question{ QuestionText = "What's 'fowl pox'?", Options = new[] { "Bacterial disease", "Viral disease", "Fungal infection", "Parasitic infection" }, Answer = "Viral disease" },
            new Question{ QuestionText = "What causes 'angel wing'?", Options = new[] { "Genetic defect", "Nutritional imbalance", "Injury", "Virus" }, Answer = "Nutritional imbalance" },
            new Question{ QuestionText = "What's 'bumblefoot'?", Options = new[] { "Foot infection", "Wing defect", "Beak deformity", "Comb disease" }, Answer = "Foot infection" },
            new Question{ QuestionText = "How often should chickens be dewormed?", Options = new[] { "Monthly", "Quarterly", "Twice yearly", "Only when needed" }, Answer = "Only when needed" },
            new Question{ QuestionText = "What's the normal body temperature of a chicken?", Options = new[] { "101-103°F (38-39°C)", "105-107°F (40-42°C)", "108-110°F (42-43°C)", "98-100°F (36-37°C)" }, Answer = "105-107°F (40-42°C)" },

            // 141-150: Egg Industry
            new Question{ QuestionText = "What country produces the most eggs?", Options = new[] { "USA", "China", "India", "Brazil" }, Answer = "China" },
            new Question{ QuestionText = "What percentage of eggs worldwide come from cage systems?", Options = new[] { "25%", "50%", "65%", "80%" }, Answer = "65%" },
            new Question{ QuestionText = "What does 'free range' legally require for egg production?", Options = new[] { "Specific space per bird", "Outdoor access", "No antibiotics", "Organic feed" }, Answer = "Outdoor access" },
            new Question{ QuestionText = "What's 'forced molting' in egg production?", Options = new[] { "Plucking feathers", "Inducing egg laying", "Extended light periods", "Temporary fasting" }, Answer = "Temporary fasting" },
            new Question{ QuestionText = "What's the average lifespan of a commercial laying hen?", Options = new[] { "1-2 years", "3-4 years", "5-6 years", "7-8 years" }, Answer = "1-2 years" },
            new Question{ QuestionText = "What's the most common egg packaging?", Options = new[] { "Plastic", "Foam", "Cardboard", "Recycled paper" }, Answer = "Cardboard" },
            new Question{ QuestionText = "What does USDA Grade AA mean for eggs?", Options = new[] { "Largest size", "Freshest quality", "Organic certification", "Special breed" }, Answer = "Freshest quality" },
            new Question{ QuestionText = "What's 'candling' in egg production?", Options = new[] { "Quality inspection", "Cleaning process", "Weight sorting", "Packaging method" }, Answer = "Quality inspection" },
            new Question{ QuestionText = "What percentage of eggs are broken during processing?", Options = new[] { "Less than 1%", "2-3%", "5-7%", "10-12%" }, Answer = "Less than 1%" },
            new Question{ QuestionText = "What's the main use for male chicks in egg production?", Options = new[] { "Meat", "Breeding", "Pets", "Euthanized" }, Answer = "Euthanized" },

            // 151-160: Cultural Significance
            new Question{ QuestionText = "In Chinese culture, what does a chicken symbolize?", Options = new[] { "Wealth", "Fidelity", "Punctuality", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What religion considers eggs unclean?", Options = new[] { "Hinduism", "Judaism", "Buddhism", "None of these" }, Answer = "None of these" },
            new Question{ QuestionText = "In Christianity, what do eggs symbolize?", Options = new[] { "Resurrection", "Purity", "New life", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What culture created the first Easter eggs?", Options = new[] { "Persian", "Mesopotamian", "Egyptian", "Greek" }, Answer = "Persian" },
            new Question{ QuestionText = "In Japanese folklore, what does the chicken symbolize?", Options = new[] { "Courage", "Dawn", "Fertility", "All of the above" }, Answer = "Dawn" },
            new Question{ QuestionText = "What culture eats balut (developing egg embryo)?", Options = new[] { "Filipino", "Chinese", "Peruvian", "Nigerian" }, Answer = "Filipino" },
            new Question{ QuestionText = "In Russian culture, what is 'khokhloma'?", Options = new[] { "Egg dance", "Painted eggs", "Chicken soup", "Egg bread" }, Answer = "Painted eggs" },
            new Question{ QuestionText = "What country has an annual 'Battle of the Eggs' festival?", Options = new[] { "Greece", "Italy", "Spain", "France" }, Answer = "Greece" },
            new Question{ QuestionText = "In Hinduism, what does the cosmic egg represent?", Options = new[] { "Universe", "Life cycle", "Karma", "Dharma" }, Answer = "Universe" },
            new Question{ QuestionText = "What culture created the Fabergé eggs?", Options = new[] { "French", "Russian", "Austrian", "British" }, Answer = "Russian" },

            // 161-170: Chicken Intelligence
            new Question{ QuestionText = "How many human words can chickens recognize?", Options = new[] { "5-10", "10-20", "20-30", "Over 100" }, Answer = "Over 100" },
            new Question{ QuestionText = "What cognitive ability do chickens share with primates?", Options = new[] { "Tool use", "Self-recognition", "Numeracy", "All of the above" }, Answer = "Numeracy" },
            new Question{ QuestionText = "How far can chickens see?", Options = new[] { "10 feet", "30 feet", "100 feet", "300 feet" }, Answer = "300 feet" },
            new Question{ QuestionText = "How many individual faces can chickens remember?", Options = new[] { "10", "30", "50", "Over 100" }, Answer = "Over 100" },
            new Question{ QuestionText = "What complex emotion have chickens demonstrated?", Options = new[] { "Empathy", "Jealousy", "Regret", "All of the above" }, Answer = "Empathy" },
            new Question{ QuestionText = "How long can chickens remember events?", Options = new[] { "1 day", "1 week", "1 month", "Several months" }, Answer = "Several months" },
            new Question{ QuestionText = "What problem-solving skill do chickens have?", Options = new[] { "Maze navigation", "Puzzle solving", "Delayed gratification", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "At what age do chicks begin learning?", Options = new[] { "Before hatching", "1 day old", "1 week old", "1 month old" }, Answer = "Before hatching" },
            new Question{ QuestionText = "How do chickens communicate food discoveries?", Options = new[] { "Specific calls", "Dance", "Leading others", "All of the above" }, Answer = "Specific calls" },
            new Question{ QuestionText = "What percentage of their time do chickens spend foraging?", Options = new[] { "10-20%", "30-40%", "50-60%", "70-80%" }, Answer = "50-60%" },

            // 171-180: Chicken Products
            new Question{ QuestionText = "What is 'isenglass' made from?", Options = new[] { "Egg shells", "Chicken feet", "Fish bladders", "Chicken combs" }, Answer = "Fish bladders" },
            new Question{ QuestionText = "What vaccine uses chicken eggs?", Options = new[] { "Polio", "Influenza", "Measles", "All of the above" }, Answer = "Influenza" },
            new Question{ QuestionText = "What beauty product contains egg?", Options = new[] { "Shampoo", "Face mask", "Hair conditioner", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What industrial use do egg shells have?", Options = new[] { "Paint", "Plastic filler", "Water filter", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What medical use do chicken eggs have?", Options = new[] { "Vaccine production", "Burn treatment", "Suture material", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What is 'egg tempera'?", Options = new[] { "Paint medium", "Egg preservation", "Cooking technique", "Medical treatment" }, Answer = "Paint medium" },
            new Question{ QuestionText = "What part of chickens is used in pet food?", Options = new[] { "Feathers", "Bones", "Organs", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What is 'chicken feather meal' used for?", Options = new[] { "Animal feed", "Fertilizer", "Insulation", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What musical instrument uses chicken skin?", Options = new[] { "Banjo", "Drum", "Violin", "Guitar" }, Answer = "Drum" },
            new Question{ QuestionText = "What is 'ovo-lacto vegetarianism'?", Options = new[] { "Eats eggs and dairy", "Only eats eggs", "Only eats chicken", "Vegan plus eggs" }, Answer = "Eats eggs and dairy" },

            // 181-190: Chicken in Space
            new Question{ QuestionText = "When were chickens first sent to space?", Options = new[] { "1957", "1961", "1968", "1973" }, Answer = "1961" },
            new Question{ QuestionText = "What country first sent chickens to space?", Options = new[] { "USA", "USSR", "China", "France" }, Answer = "USSR" },
            new Question{ QuestionText = "How many chicken eggs have been fertilized in space?", Options = new[] { "None", "12", "24", "Over 50" }, Answer = "Over 50" },
            new Question{ QuestionText = "Have chickens ever hatched in space?", Options = new[] { "Yes", "No", "Only partially developed", "Only in simulation" }, Answer = "No" },
            new Question{ QuestionText = "What space station experiment involved chicken eggs?", Options = new[] { "Mir", "Skylab", "ISS", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "Why are chicken eggs studied in space?", Options = new[] { "Development in microgravity", "Radiation effects", "Space farming potential", "All of the above" }, Answer = "All of the above" },
            new Question{ QuestionText = "What problem occurs when trying to incubate eggs in space?", Options = new[] { "Temperature control", "Turning eggs", "Humidity", "All of the above" }, Answer = "Turning eggs" },
            new Question{ QuestionText = "What chicken organ is studied for space adaptation?", Options = new[] { "Eyes", "Inner ear", "Heart", "Lungs" }, Answer = "Inner ear" },
            new Question{ QuestionText = "How long can fertilized chicken eggs survive in space?", Options = new[] { "1 day", "1 week", "2 weeks", "Full term" }, Answer = "Full term" },
            new Question{ QuestionText = "What space food contains eggs?", Options = new[] { "Scrambled eggs", "Egg salad", "Quiche", "All of the above" }, Answer = "All of the above" },

            // 191-200: Final Random Facts
            new Question{ QuestionText = "What dinosaur is the chicken's closest relative?", Options = new[] { "T-Rex", "Velociraptor", "Triceratops", "Stegosaurus" }, Answer = "T-Rex" },
            new Question{ QuestionText = "How many muscles control a chicken's ear?", Options = new[] { "0", "4", "8", "12" }, Answer = "0" },
            new Question{ QuestionText = "What percentage of chicken meat is white?", Options = new[] { "25%", "50%", "75%", "100%" }, Answer = "50%" },
            new Question{ QuestionText = "How many eggs would it take to reach the moon?", Options = new[] { "10 million", "100 million", "1 billion", "10 billion" }, Answer = "10 billion" },
            new Question{ QuestionText = "What's the fastest recorded chicken speed?", Options = new[] { "9 mph", "14 mph", "20 mph", "25 mph" }, Answer = "14 mph" },
            new Question{ QuestionText = "How many eggs does the average person eat yearly?", Options = new[] { "50", "100", "200", "300" }, Answer = "300" },
            new Question{ QuestionText = "What percentage of chickens are left-handed?", Options = new[] { "0%", "10%", "25%", "50%" }, Answer = "0%" },
            new Question{ QuestionText = "How many eggs were used in 'Cool Hand Luke'?", Options = new[] { "25", "50", "75", "100" }, Answer = "50" },
            new Question{ QuestionText = "What's the world's most expensive chicken breed?", Options = new[] { "Ayam Cemani", "Serama", "Olandsk Dwarf", "Phoenix" }, Answer = "Ayam Cemani" },
            new Question{ QuestionText = "How many chickens are killed every second worldwide?", Options = new[] { "5", "50", "500", "5000" }, Answer = "50" }
        }
    };
}