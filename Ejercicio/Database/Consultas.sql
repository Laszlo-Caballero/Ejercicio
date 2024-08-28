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