# Todo List Application API

This is the backend API for the **Todo List Application**, built using **C#** and **.NET Core Rest API**, and designed to seamlessly integrate with the Angular 16 frontend. The project is aimed at simplifying task management, allowing users to create, track, and manage their daily tasks efficiently.

## 🌟 Features

- **Domain-Driven Design**: A clean and scalable architecture for easy maintenance and future enhancements.
- **Repository Pattern**: Implements a **Generic Repository** with a **Unit of Work** architecture for better separation of concerns.
- **Entity Framework Core (ORM)**: Simplified database interactions with LINQ queries and migrations.
- **CRUD Operations**:
  - Create and read tasks.
  - Mark tasks as completed or revert them to "not completed."
  - Delete tasks with a soft delete functionality.
- **Pagination**: Optimized data loading for efficient task management.
- **Undo Delete**: Allows users to recover accidentally deleted tasks.
- **User Feedback**:  
  - **Toaster Messages**: Provides warnings when hovering over the delete button.
  - **Alert System**: Prompts the user for confirmation if the delete button is hovered over for too long.

## 🎯 Purpose

The **Todo List Application** is designed to make life easier by providing a user-friendly platform for managing daily tasks. The API ensures smooth, reliable, and efficient operations for the Angular frontend.

## 🛠️ Tech Stack

- **Backend**:  
  - C#
  - .NET Core Rest API  
  - Entity Framework Core  

- **Frontend**:  
  - Angular 16  

- **Architecture**:  
  - Domain-Driven Design (DDD)  
  - Repository Pattern with Unit of Work

    
---

