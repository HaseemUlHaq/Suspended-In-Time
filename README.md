# Suspended In Time

![Suspended In Time logo](_image_) IMG

## Introduction

**Suspended In Time** is an interactive educational virtual reality experience developed using Unity and designed for the Meta Quest 2 headset. The experience allows users to explore a dark environment where everything is paused and life has stopped, and interact with the environment by manipulating sunlight to restore motion and vitality.

The core idea of the project is based on the concept of revealing hidden life through light. The world initially appears static and paused. When the user moves the sun across the environment, sunlight highlights certain elements; those highlighted objects become interactable (e.g. butterflies, fire, plants, and other environmental objects).

The problem addressed in this project is how to create intuitive and immersive interactions in XR environments that encourage exploration and discovery. Traditional interfaces rely on menus and buttons, which can reduce immersion in virtual reality experiences.

The proposed solution is a light-driven interaction system where environmental objects react dynamically when exposed to sunlight. This interaction design encourages users to explore the environment naturally and learn through experimentation.

This project demonstrates how simple interaction mechanics, environmental storytelling, and spatial interaction can create an engaging XR learning experience.

## Design Process

The design and development of the project followed an iterative process that included ideation, prototyping, testing, and refinement.

### Brainstorming

The initial concept was developed through brainstorming sessions exploring themes of environmental interaction, discovery, and transformation. The final idea centered on a world suspended in time where everything is initially stopped and sunlight acts as the key interaction mechanic.

### User Research

The target users of this project are students and XR learners exploring immersive environments. Observations from existing XR applications suggested that users prefer natural interactions, such as grabbing objects or pointing at elements, rather than navigating complex menus.

Key insights:

- Users engage more when interactions feel physical and spatial
- Visual feedback helps users understand interaction mechanics
- Simple interaction loops are easier to learn in VR

These insights influenced the design of the sunlight interaction system.

### User Persona

**Name:** Alex  
**Age:** 22  
**Background:** University student interested in immersive technology.

**Needs:**

- Easy to understand VR interactions
- Visually engaging environments
- Interactive elements that encourage exploration

**Pain Points:**

- Complex controls in VR applications
- Lack of meaningful interaction in some virtual environments

Suspended In Time addresses these issues by providing simple controller-based interaction and clear visual feedback.

### User Journey

1. The user enters a dark environment where everything is paused.
2. A movable sun object appears in the sky.
3. The user grabs and moves the sun using the VR controller.
4. As sunlight highlights objects in the environment, they become interactable.
5. The user interacts with these objects to restore life to the world.

This journey encourages curiosity, exploration, and discovery.

### Wireframes and Prototypes

Early prototypes focused on testing:

- Sun movement mechanics
- Light detection systems
- Object interaction behaviors

Several iterations were made to refine:

- Sun movement constraints
- Interaction detection using light zones
- Object activation behaviors

(Insert prototype screenshots here) IMG

## System description

### Features

Suspended In Time includes several interactive features designed to create an immersive and engaging VR experience.

- **Light-Driven Interaction** – The central interaction mechanic allows the user to move the sun across the sky. Initially everything is stopped, objects highlighted by sunlight become interactable.

- **Interactive Environmental Objects** – Different objects react to sunlight and user interaction:
  - **Butterflies** – Butterflies that are paused begin flying when grabbed while highlighted by sunlight.
  - **Fire Object** – A fire ignites when the object is grabbed while highlighted by sunlight.
  - **Environmental Activation** – Highlighted objects become interactable, only those in sunlight can be activated.

(Insert screenshots or GIF demonstrations here) IMG

- **Sun Manipulation** – Users can grab and move a sun object in the sky using VR controllers, directing light toward different parts of the environment.

- **Reset Mechanism** – A reset system restores the environment to its initial paused state by:
  - Resetting object positions
  - Disabling animations
  - Returning the sun to its original position

- **VR Interaction** – The project uses controller-based interaction provided by the Unity XR Interaction Toolkit.

Watch the demo video or try the live version.

Link: (Add your demo or live version link here) IMG

## Installation

To install and run Suspended In Time locally, follow the instructions below.

| Platform | Device     | Requirements                          | Commands |
| -------- | ---------- | ------------------------------------- | -------- |
| Windows  | Meta Quest 2 | Unity 2022.3+, Android Build Support | `git clone https://github.com/HaseemUlHaq/Suspended-In-Time.git`<br>`cd Suspended-In-Time`<br>Open project in Unity<br>Switch platform to Android<br>Build and Run |

**Requirements:**

- Unity 6000.3 LTS or newer
- Unity XR Interaction Toolkit
- Android Build Support
- Meta Quest 2 headset

You also need to install the following dependencies or libraries for your project:

- **Unity XR Interaction Toolkit** – For VR controller interaction and grab mechanics

## Usage

To interact with the Suspended In Time experience, follow the guidelines below.

**Movement**

- Use the left joystick on the controller to move around the environment.

**Moving the Sun**

- Point the controller at the sun.
- Grab the sun using the controller grip button.
- Move the sun across the sky to illuminate different areas.

**Activating Objects**

- Objects highlighted by sunlight become interactable.
- Grab a highlighted object to activate it.

Examples:

- Grab a highlighted butterfly to make it fly.
- Grab the highlighted fire object to ignite the flame.

## References

The following tools and resources were used during the development of this project:

- **Unity Game Engine** – <https://unity.com/>
- **Unity XR Interaction Toolkit** – Unity’s official XR interaction framework
- **Free assets from the Unity Asset Store** – Environmental and interactive 3D assets
- **Particle effects** – For environmental interactions

Additional inspiration was taken from existing VR experiences that focus on environmental storytelling and interaction design.

## Contributors

**Haseem Ul Haq**  
Software Engineer & XR Developer
- LinkedIn: https://www.linkedin.com/in/haseem-ul-haq/

**Raman Ghimire**  
AI/ML Engineer & XR Developer
- LinkedIn: https://www.linkedin.com/in/ghimirermn/

**Naveed Karim**  
Creative Visual Designer & XR Developer
- LinkedIn: https://www.linkedin.com/in/naveedkarim80/
