<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Code Highlighting Example</title>

  <!-- Highlight.js Dark Theme -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/highlight.js/11.8.0/styles/atom-one-dark.min.css">

  <style>
    
    /* Sidebar styling */
    .sidebar {
      position: fixed;
      top: 10px;
      left: 10px;
      width: 250px;
      padding: 10px;
      border: 1px solid #ccc;
      border-radius: 5px;

    }

    .sidebar h3 {
      margin-top: 0;
    }

    .sidebar a {
      display: block;
      padding: 5px 0;
      text-decoration: none;
      color: #ccc;
    }

    /* Main content styling */
    .content {
      margin-left: 270px;
      padding: 10px;
    }

    section {
      padding: 20px;
      margin-bottom: 40px;
      border: 1px solid #ccc;
      border-radius: 5px;
    }

    pre {
      padding: 15px;
      border-radius: 5px;
      overflow-x: auto;
    }

    .box {
    background-color: #2d2d2d;
    padding: 10px;
    border-left: 5px solid #555;
    font-size: 16px;
    width: 100%; /* Ensures the box stretches to the full line */
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.3);
    box-sizing: border-box; /* Includes padding and border in width */
    display: block; /* Makes the element stretch to the full line */
    color: #fff; /* Ensures text is readable */
}
  </style>
</head>
<body>

  <!-- Sidebar -->
  <div class="sidebar">
    <h2>Agenda</h2>
    <ul>
      <li><a href="#section1">Introduction</a></li>
      <li><a href="#section2">Main Topic</a></li>
      <li><a href="#section3">Conclusion</a></li>
    </ul>
  </div>

  <!-- Main Content -->
  <div class="content">
    <section id="section2">
      <h2>Main Topic</h2>
      <p>This is the main topic section.</p>
      <details>
        <summary><strong  lass="box">1. Feature/Task Name</strong></summary>
        <h3>Summary</h3>
        <ul>
          <li><strong>Branch Name:</strong> <code>feature/task-name</code></li>
          <li><strong>Status:</strong> In Progress / Completed / Blocked</li>
          <li><strong>Start Date:</strong> YYYY-MM-DD</li>
          <li><strong>Completion Date:</strong> YYYY-MM-DD</li>
          <li><strong>Tags:</strong> Feature, Backend, UI, etc.</li>
        </ul>
        <details>
          <summary><strong>Implementation Details</strong></summary>
          <ul>
            <li><strong>Goal:</strong> Briefly describe the purpose of this feature/task.</li>
            <li><strong>Steps:</strong>
              <ol>
                <li>Step 1 description</li>
                <li>Step 2 description</li>
                <li>Step 3 description</li>
              </ol>
            </li>
            <li><strong>Code Snippets:</strong>
              <pre><code class="language-csharp">
// comment
public void ExampleMethod() {
    Console.WriteLine("Hello, World!");
}
              </code></pre>
            </li>
            <li><strong>Challenges Faced:</strong>
              <ul>
                <li>Challenge 1 and how it was resolved.</li>
                <li>Challenge 2 and how it was resolved.</li>
              </ul>
            </li>
            <li><strong>Resources/Links:</strong>
              <ul>
                <li><a href="#">Link to design document</a></li>
                <li><a href="#">Link to PR or issue</a></li>
              </ul>
            </li>
            <li>> Do not push the big red button.
</li>
          </ul>
        </details>
      </details>
    </section>
    <section id="section1">
  <details open>
    <summary id="1-4"><strong>1-4</strong></summary>
    <h3>Summary</h3>
    <ul>
      <li><strong>Branch Name:</strong> <code>feature/01_introduction</code></li>
      <li><strong>Course Summary:</strong>
        <ul>
          <li>Section 1: Course Introduction</li>
          <li>Section 2: What are Microservices, when to use it</li>
          <li>Section 3: redundant</li>
          <li>Section 4: redundant</li>
        </ul>
      </li>
    </ul>
    <details open>
      <summary><strong>Course Details</strong></summary>
      <ul>
        <li><strong>Course Info:</strong>
          <ul>
            <li>
              <a href="https://atp.udemy.com/course/microservices-architecture-and-implementation-on-dotnet/learn/lecture/42551424#overview" target="_blank">
                Develop Microservices on .NET 8 used ASP.NET Web API, Docker, RabbitMQ, MassTransit, gRPC, Yarp Gateway, Redis, SqlServer
              </a>
            </li>
            <li>Author: Mehmet Ozkaya</li>
          </ul>
        </li>
        <li><strong>Source Code:</strong>
          <ul>
            <li><a href="https://github.com/aspnetrun/run-aspnetcore-microservices" target="_blank">Community's Repo</a></li>
            <li><a href="https://github.com/mehmetozkaya/AspnetMicroservices" target="_blank">Author's Repo old .Net 5</a></li>
            <li><a href="https://github.com/mehmetozkaya/EShopMicroservices-Udemy-Sections" target="_blank">Author's Repo by section</a></li>
            <li><a href="https://github.com/mehmetozkaya/EShopMicroservices" target="_blank">Author's Repo new .Net 8</a></li>
            <li><a href="https://github.com/VHTrung52/04_Basic_Microservice_1" target="_blank">My repo</a></li>
          </ul>
          <p>Code structure:</p>
          <img src="img/1-4/image-8.png" alt="Code Structure">
        </li>
        <li><strong>Prerequisites Software:</strong>
          <ul>
            <li>Visual Studio / Rider</li>
            <li>.Net 8</li>
            <li>Docker Desktop</li>
            <li>Postman</li>
          </ul>
        </li>
        <li><strong>Project Technology:</strong>
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_34.jpg" alt="Project Tech 1">
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_15.jpg" alt="Project Tech 2">
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_22.jpg" alt="Project Tech 3">
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_16.jpg" alt="Project Tech 4">
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_17.jpg" alt="Project Tech 5">
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_18.jpg" alt="Project Tech 6">
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_19.jpg" alt="Project Tech 7">
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_20.jpg" alt="Project Tech 8">
          <img src="img/1-4/1734321999000-e6a3e4a3-3edf-46fe-9d11-d6cd0e5feb28_21.jpg" alt="Project Tech 9">
        </li>
        <li><strong>Run The Final Application:</strong>
          <ol>
            <li>Clone the final project:
              <pre><code>git clone https://github.com/mehmetozkaya/EShopMicroservices</code></pre>
            </li>
            <li>Open project with Visual Studio / Rider and rebuild project (expect: build success)</li>
            <li>Set Docker as startup project:
              <ul>
                <li>For <strong>Visual Studio</strong>: Set <code>docker-compose</code> as startup project</li>
                <li>For <strong>Rider</strong>: Set run configuration to <code>docker-compose.yml</code></li>
              </ul>
            </li>
            <li>Run project:
              <p>Note for <strong>Rider</strong>: If the message <code>pull access denied repository does not exist or may require docker login</code> appears, this is normal. Just wait a few minutes.</p>
            </li>
            <li>The result:
              <ul>
                <li>Docker: <img src="img/1-4/image-2.png" alt="Docker Result"></li>
                <li>Web application:
                  <img src="img/1-4/image-3.png" alt="Web App 1">
                  <img src="img/1-4/image-4.png" alt="Web App 2">
                  <img src="img/1-4/image-5.png" alt="Web App 3">
                  <img src="img/1-4/image-6.png" alt="Web App 4">
                </li>
                <li>RabbitMQ: <img src="img/1-4/image-7.png" alt="RabbitMQ Result"></li>
              </ul>
            </li>
          </ol>
        </li>
      </ul>
    </details>
  </details>
    </section>
    <section id="section3">
      <h2>Conclusion</h2>
      <p>This is the conclusion section.</p>
    </section>
  </div>

  <!-- Highlight.js Script -->
  <script src="https://cdnjs.cloudflare.com/ajax/libs/highlight.js/11.8.0/highlight.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/highlight.js/11.8.0/languages/csharp.min.js"></script>
  <script>
    // Initialize Highlight.js
    hljs.highlightAll();
  </script>
</body>
</html>