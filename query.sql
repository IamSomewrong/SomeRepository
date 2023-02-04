/* 
    Таблицы Products и Categories состоят из 2ух столбцов: id, и имени продукта и категории соответственно.
    Таблица productscategories состоит из 3 столбцов: id, id продукта и id категории. Связывает две другие таблицы связью многжество к множеству.
*/
select pr.name as Product, cat.name as Category
from products_t pr
left join productscategories pc on pc.prod_id = pr.id
left join categories_t cat on pc.cat_id = cat.id
order by pr.Name, cat.Name