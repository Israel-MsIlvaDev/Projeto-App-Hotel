# 🏨 MauiAppHotel

Aplicativo desenvolvido em **.NET MAUI** como parte do meu curso técnico em Desenvolvimento de Sistemas.  
O objetivo é simular a contratação de uma hospedagem em hotel, permitindo que o usuário escolha o tipo de suíte, informe datas de estadia, quantidade de hóspedes e visualize o valor total da reserva.

---

## 🇧🇷 Descrição (Português)

O **MauiAppHotel** é um app de exemplo construído com **.NET MAUI** que trabalha com:

- Navegação por **abas** usando `Shell`:
  - Aba **Hospedagem** (contratação da reserva)
  - Aba **Sobre** (informações sobre o desenvolvedor e o projeto)
- Tela de contratação de hospedagem:
  - Escolha do **tipo de suíte** (`Standard`, `Luxo`, `Premium`)
  - Definição da **data de check-in** e **check-out** com `DatePicker`
  - Seleção da quantidade de **adultos** e **crianças** com `Stepper`
  - Validação básica de datas (check-out precisa ser depois do check-in)
  - Cálculo automático do **valor total da hospedagem**, com diárias diferentes para adultos e crianças
- Tela de resumo da hospedagem:
  - Mostra nome do quarto, quantidade de hóspedes, quantidade de dias de estadia e o **valor total calculado**
  - Botão para **iniciar uma nova reserva** retornando à tela anterior
- Tela **Sobre**:
  - Informações sobre o desenvolvedor
  - Contexto acadêmico do projeto (curso técnico, ano etc.)

Todo o cálculo é feito no cliente, usando a classe `Hospedagem` para centralizar regras como:
- cálculo do número de dias entre check-in e check-out
- cálculo do valor total com base na suíte, quantidade de adultos e crianças

---

## 🇬🇧 Description (English)

**MauiAppHotel** is a sample application built with **.NET MAUI** as part of a Technical Course in Systems Development.  
The app simulates a hotel booking flow where the user can choose a suite type, select check-in/check-out dates, set the number of guests and see the total amount for the stay.

Main features:

- **Tab-based navigation** using `Shell`:
  - **Booking** tab (hotel reservation screen)
  - **About** tab (developer and project information)
- Booking screen:
  - Choose the **suite type** (`Standard`, `Luxury`, `Premium`)
  - Select **check-in** and **check-out** dates using `DatePicker`
  - Set the number of **adults** and **children** using `Stepper` controls
  - Basic validation to ensure check-out is after check-in
  - Automatic calculation of the **total booking price**, with different daily rates for adults and children
- Booking summary screen:
  - Shows the selected room, number of guests, length of stay (in days) and the **calculated total amount**
  - Button to **start a new booking**, going back to the previous page
- **About** screen:
  - Information about the developer
  - Academic context of the project (technical course, year, etc.)

Business logic is encapsulated in the `Hospedagem` model, which:
- calculates the number of days between check-in and check-out
- calculates the total price based on suite pricing and number of adults/children

---

## 🛠️ Tecnologias / Technologies

- .NET 8
- .NET MAUI
- Visual Studio 2022

---

## ▶️ Como executar / How to run

### 🇧🇷 Passos para executar (Português)

1. Clone o repositório usando:
```bash```
   git clone https://github.com/Israel-MslIvaDev/MauiAppHotel.git

2. Abra o projeto no Visual Studio 2022.

3. Certifique-se de que o workload “.NET Multi-platform App UI (MAUI)” está instalado no Visual Studio.

4. No seletor de dispositivos, escolha onde deseja rodar o app:
   - Máquina Windows
   - Emulador Android
   - Dispositivo Android físico

5. Pressione F5 ou clique no botão **Run** para compilar e iniciar o aplicativo.

---

### 🇬🇧 Steps to run (English):

1. Clone the repository using:
```bash```
   git clone https://github.com/Israel-MslIvaDev/MauiAppHotel.git

3. Open the solution with Visual Studio 2022.

4. Make sure the “.NET Multi-platform App UI (MAUI)” workload is installed.

5. In the device selector, choose where you want to run the app:
   - Windows Machine
   - Android Emulator
   - Physical Android device

6. Press F5 or click **Run** to build and launch the application.
