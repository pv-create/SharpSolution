Тут будет краткая документация оп проекту
<ul>
    <li>
        то что обсуждается на встречах
    </li>
    <li>
        Правила работы с проектом
    </li>
    <li>
        правила работы с репозиторием
    </li>
    <li>
        порядок проведения code-review
    </li>
</ul>


<h1>Правила работы с репозиторием</h1>
Для создания новой фичи нужно создать новую ветвь. Формат наименования ветви feature-feature-name
<h2>Важно никогда не работать и ничего не комитить в ветвь master, код попадает в ветвь мастер только 
через pull-request.</h2>
По возможности будем стараться проводить ревью кода

<h1>Правила работы с проектом</h1>

<details>
<summary>Проект Domain</summary>
В данном проекте (библиотека классов) будут описаны сущьности нашего приложения и интерфесы. 
Очень важно, что бы проект имел минимальное количесво ссылок на сторонние библиотеки.
</details>

<details>
<summary>Проект Db</summary>
В данно проекте описана логика работы с бд (сюда же будет добавлена orm), тут будут описаны репозитории нашего нашего приложения
(также в проекте планируем использовать кэширование, например redis)
</details>

<details>
<summary>Проект Application</summary>
В данном проекте описываем бизнес логику
</details>

<details>
<summary>Проект Infrustructure</summary>
В данном проекте будут классы обеспечивающие генерацию отчетов, метрик, и работу почтовой расслки. 
</details>

<details>
<summary>Проект Web</summary>
Слой контроллеров нашего приложения, который будет связывать все предыдущие слои
</details>

