# History of my designs

In reverse chronological order because I have no patience :)

## Version 2

Concept = the atomic unit which contains meaning. 

Context = a collection of true statements that describe the background in which concepts are interpreted. It is impossible to interpret concepts without a context because without a context, words have no meaning. Even simple concepts such as "cat" (the animal) and "microphone" (the tech object that takes sound as input and converts it into some digital format) need the context of living on the planet Earth in the 21st century to have meaning. Microphone wouldn't have meaning in the year 300 B.C. "Cat" wouldn't have meaning back when the Earth didn't have an atmosphere.

Knowledge = a string of concepts with matching output-intput connections. Their ICommunicationType needs to be of the same implementation. 

Wisdom = a congruent combination of knowledge and context. 

```csharp
public class Concept
{
	public ICommunicationType Input;
	public ICommunicationType Output;
	public List<Attributes> Attributes;
	
	public List<Actions> ComputeActionsFromAttributes();
}
```

### Notes

For me, as a human, I feel that I store concepts in a mix of emotions and unspoken feelings. I can put concepts together and think without needing words. It's an effort to translate these concept feelings into words such as the English language. I'm thinking of modeling this in my AI. A word can refer to a single concept or multiple words such as a description can refer to a single concept. And the same word can refer to different concepts depending on the context.

---

## Version 1

Building Block = a unit of knowledge which cannot be broken into other units. Like an axiom. "paper" is a building block in origami, "only one line can pass through two dots" is a building block of Euclidean geometry. "bit" is a building block in computer science.

Concept = A unit of knowledege, which can be broken down into other concepts all the way down to building blocks. "crane" is a concept in origami. "rectangle" is a concept in Euclidean geometry. "merge sort" is a concept in computer science.

```csharp
public class Concept
{
	public string Name { get; }
	public string Domain { get; }
	public string Definition { get; }
	public string WikipediaLink { get; }
}
```

### Source Data Format

#### .txt
Each line is the title of a wikipedia page refering to a concept. 
For example:

writing_systems.txt
acrophony
rebus
afaka
ndyuka
yugtun
yup'ik
bete
cherokee
man'yogana

#### .csv
Title of csv file is the name of the topic such as origami and it contains the atomic concepts in that topic such as mountain fold, valley fold, paper and so on. For each row, the columns are: name of the topic, definition of the topic and the wikipedia link to the page on the topic.
For example:

origami.csv
| Concept | Definition | Wikipedia link |
| --- | --- | --- |
| mountain fold | An origami basic folding technique where you fold the paper toward you | https://en.wikipedia.org/wiki/Yoshizawa%E2%80%93Randlett_system#Basic_folds | 
| valley fold | An origami basic folding technique where you fold the paper away from you | https://en.wikipedia.org/wiki/Yoshizawa%E2%80%93Randlett_system#Basic_folds | 
| wet fold | An origami technique in which you dampen the paper with water to sculpt the paper around the geometric folding | https://en.wikipedia.org/wiki/Wet-folding |





