# Project-5-Slideshow

Objective

The aim of this project is to create a picture viewer with different functionalities. To be more precise, the user has to be able to insert a URL and view the corresponding picture. What’s more, the user must have the option to choose a directory and view the pictures from the directory in slideshow, as well as normal modes.

Description/Method

As I have already mentioned above, the aim of this project is to create a picture viewer with different kinds of functionalities. Several strategies were used in order to achieve the goal. The program includes different classes as well as interfaces.
Firstly, the classes will be considered. The program involves public partial class Form1 which inherits from Form and forMyPen. forMyPen is an interface and will be discussed in the next paragraph. Form1 has different fields as well as methods. MyImageCollection is a very important component of class Form1 since it is a collection of strings which contains the paths. The program also includes an integer type Counter and several bool type variables. Now that the fields are already considered, the methods may be discussed. Form 1 includes several methods. These methods allow the user to display the picture when a URL is passed to the program. Moreover, there are functions that allow the user to see next as well as previous pictures. Moreover, there is a method which turns on/off the slideshow mode. For more detailed information, please see the fully commented code.
Next I want to discuss the strategy for transitions. The assignment required using graphics object/drawing with graphics object for the transitions between different images. Two different pictureboxes were created. One of the pictureboxes displays the images while the other one has an image drawn by graphics object. The image says “next” image. The two pictures are swapped when the program goes from one to another image.
The program also involves another class FutureImplementation which inherits from Form1. The class includes only one method in oder to take a step ahead and use it for the future improvements. The function overrides MyPenComparator method and demonstrates the phenomenon of polymorphism.
Now that the classes are already considered, the interfaces may be discussed. There are two interfaces. One of the interfaces was created manually - forMyPen which by itself uses IComparable<Pen>.
