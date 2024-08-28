
create or alter procedure InsertarPro
@COD char(5),
@DESC varchar(50),
@PRE money,
@STK_ACT int,
@STK_MIN int,
@MED varchar(30),
@IMP varchar(10)
as
begin
	insert into TB_PRODUCTO (COD_PRO, DES_PRO, PRE_PRO, STK_ACT, STK_MIN, UNI_MED, LIN_PRO, IMPORTADO)
	VALUES(@COD, @DESC,@PRE, @STK_ACT, @STK_MIN, @MED, 3, @IMP)
end

EXEC InsertarPro @COD, @DESC, @PRE, @STK_ACT, @STK_MIN, @MED, @IMP


select * from TB_DISTRITO



SELECT COD_DIS FROM TB_DISTRITO where NOM_DIS = 'San luis'
SELECT * FROM TB_VENDEDOR


insert into TB_VENDEDOR (COD_VEN, NOM_VEN, APE_VEN, SUELDO_VEN, FEC_ING, TIP_VEN, COD_DIS)
values('V11', 'pepito', 'alcantara', 1200, '12/07/24', 2, (select COD_DIS from TB_DISTRITO where NOM_DIS = 'San luis'))
