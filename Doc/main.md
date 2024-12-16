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
      <h2>Introduction</h2>
      <p>This is the introduction section.</p>
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
